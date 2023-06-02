using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
using System.Security.Cryptography.Pkcs;

namespace Termproject
{
    public partial class Form1 : Form
    {
        private Control control = null;
        public int gamemode = 0; //0서버연결전 1배치중 2맵전송 3게임진행
        public int thismode = 0; //0client 1server
        TcpClient tcpClient1;
        StreamReader streamReader1;  // 데이타 읽기 위한 스트림리더
        StreamWriter streamWriter1;  // 데이타 쓰기 위한 스트림라이터  
        string receiveData1;

        //게임세팅용
        public int[,,] myfieldsetting = new int[13, 13, 2]; //0~9 맵 안 10~12맵밖 버그방지영역 내수용 좌표 좌표 1,0 과 배 번호 1~10(14~11_4)
        public int[] shipsready = new int[10]; //배 배치 확인

        //게임진행용
        string[] enemymapdata;
        int[,,] enemyfielddata = new int[10, 10, 2];
        int[,,] myfielddata = new int[10, 10, 2];

        public int[] shipservive = new int[11]; //0없고 1 ship14 10 ship11_4

        int gameturn; //0 선/내턴 1 후/상대턴
        string[] enemyattack; //x좌표 y좌표 무기종류 0포 1어뢰 2폭탄
        int enemyattacking = 0;
        int gameretry = 0;
        Random random= new Random();

        public Form1()
        {
            InitializeComponent();
            labelipadress.Text = Fillip();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = this.btnretry.BackColor;
            labelready.Visible = true;
            
            btnretry.Click += reset_Click;
            FormClosing += shutdownevent;
            CheckForIllegalCrossThreadCalls = false; //디버그시 쓰레드 크로스 경고 방지
        }

        private void shutdownevent(object? sender, FormClosingEventArgs e)
        {
            streamWriter1.WriteLine("shutdown");
        }

        string Fillip()
        {
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());

            string ipadress = "";

            foreach (var address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipadress = address.ToString();
                }
            }
            return ipadress;
        }


        private void ClientConnect_Click(object sender, EventArgs e)  // '연결하기' 버튼이 클릭되면
        {
            Thread thread1 = new Thread(connect); // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true; // Form이 종료되면 thread1도 종료.
            thread1.Start(); // thread1 시작.
            btnJoinGame.Enabled = false;
            btnServerMode.Enabled = false;
        }

        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            tcpClient1 = new TcpClient();  // TcpClient 객체 생성
            if (thismode == 0) //클라모드
            {
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(InsertIpTextBox.Text), 5000);  // IP주소와 Port번호를 할당
                tcpClient1.Connect(ipEnd);  // 서버에 연결 요청
                writeRichTextbox("서버 연결됨...");

                //streamWriter1.WriteLine("connected");  // 스트림라이터를 통해 데이타를 전송
            }
            else if (thismode == 1) //서버모드
            {
                TcpListener tcpListener1 = new TcpListener(IPAddress.Parse(labelipadress.Text), 5000); // 서버 객체 생성 및 IP주소와 Port번호를 할당
                tcpListener1.Start();  // 서버 시작
                writeRichTextbox("서버 준비...클라이언트 기다리는 중...");

                tcpClient1 = tcpListener1.AcceptTcpClient(); // 클라이언트 접속 확인
                writeRichTextbox("클라이언트 연결됨...");

            }
            streamReader1 = new StreamReader(tcpClient1.GetStream());  // 읽기 스트림 연결
            streamWriter1 = new StreamWriter(tcpClient1.GetStream());  // 쓰기 스트림 연결
            streamWriter1.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..
            
            if (thismode == 1)//서버
            {
                gameturn = 0; //선
                if (random.Next(0, 2) == 0)
                {
                    streamWriter1.WriteLine("serverfirst");
                    gameturn = 0; //선
                }
                else
                {
                    streamWriter1.WriteLine("clientfirst");
                    gameturn = 1; //후
                }
                Setpanel.Location = new Point(0, 0);
                this.Size = new Size(1250, 650);
                gamemode = 1;
            }

            while (tcpClient1.Connected)  // 클라이언트가 연결되어 있는 동안
            {
                receiveData1 = streamReader1.ReadLine();
                if(receiveData1=="shutdown")
                {
                    tcpClient1.Close();
                    DialogResult dr =  MessageBox.Show("상대의 통신이 두절되었습니다.","통신 종료", MessageBoxButtons.OK);
                    if(dr == DialogResult.OK)
                    {
                        Application.Exit();
                    }

                }
                else if(receiveData1 == "turnend")
                {
                    myturn();
                }
                else if (gamemode == 0)
                {
                    if (thismode == 0)//클라
                    {
                        //receiveData1 = streamReader1.ReadLine();
                        while (receiveData1 != "serverfirst" && receiveData1 != "clientfirst") { }
                        if (receiveData1 == "serverfirst")
                            gameturn = 1; //후
                        if (receiveData1 == "clientfirst")
                            gameturn = 0; //선
                        Setpanel.Location = new Point(0, 0);
                        this.Size = new Size(1250, 650);
                        gamemode = 1;
                    }
                }
                else if (gamemode == 1)
                {
                    //receiveData1 = streamReader1.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장 //상대 종료시 강종 위치
                    enemymapdata = receiveData1.Split('/');

                    for (int j = 0; j < 10; j++)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            enemyfielddata[9-i, j, 0] = int.Parse(enemymapdata[i * 20 + j*2]);
                            enemyfielddata[9-i, j, 1] = int.Parse(enemymapdata[i * 20 + j*2+1]);
                        }
                    }//수신완료
                    while (btnReady.Enabled==true) { }

                    if (gameturn == 1)
                        enemyturn();

                    enemyfield.Location = new Point(650, 50);
                    btntorpedo.Location = new Point(50, 550);
                    btnbomb.Location = new Point(230, 550);
                    arrow.Location = new Point(556, 153);
                    btnReady.Location = new Point(1850, 450);
                    btnReset.Location = new Point(1650, 450);
                    labelready.Location = new Point(1338, 493);
                    if (gameturn == 0)
                        arrow.Image = Properties.Resources.flagright;
                    else if (gameturn == 1)
                        arrow.Image = Properties.Resources.flagleft;

                    gamemode = 2;
                }
                else if (gamemode == 2) //게임진행
                {
                    //receiveData1 = streamReader1.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장 x좌표/y좌표
                    enemyattack = receiveData1.Split('/');
                    if (enemyattack[2] == "0")
                        enemyattack[0] = (9 - int.Parse(enemyattack[0])).ToString();
                    else if (enemyattack[2] == "2")
                        enemyattack[0] = (7 - int.Parse(enemyattack[0])).ToString();

                    if (enemyattack[0] !="retry")
                        enemyattacking = 1;

                }
                else if (gamemode == 3) //게임진행
                {
                    //receiveData1 = streamReader1.ReadLine();
                    if (receiveData1 == "retry")
                    {
                        gameretry = 1;
                        btnretry.Enabled= true;
                    }
                }
                richTextBox2.Text += receiveData1;
                richTextBox2.Text += "\r\n";
            }
        }
        private void ServerOpen_Click(object sender, EventArgs e)
        {
            if (thismode == 0)
            {
                thismode = 1;
                btnServerMode.Text = "게임 생성 모드";
                btnJoinGame.Text = "게임 생성";
                btnJoinGame.Enabled = true;
                InsertIpTextBox.Enabled = false;
                InsertIpTextBox.Visible = false;
            }
            else if (thismode == 1)
            {
                thismode = 0;
                btnServerMode.Text = "게임 참가 모드";
                btnJoinGame.Text = "게임 참가";
                if (thismode == 0 && InsertIpTextBox.Text == "")
                    btnJoinGame.Enabled = false;
                else if (thismode == 0 && InsertIpTextBox.Text != "")
                    btnJoinGame.Enabled = true;
                InsertIpTextBox.Enabled = true;
                InsertIpTextBox.Visible = true;
            }
        }

        private void writeRichTextbox(string str)  // richTextbox1 에 쓰기 함수
        {
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText(str + "\r\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.ScrollToCaret(); });  // 스크롤을 젤 밑으로.
        }

        private void question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("※게임규칙※\r\r게임생성 모드로 게임을 생성하면 자신의 IP주소를 상대에게 알려주세요.\r게임참가 모드에선 상대의 IP를 입력하고 게임참가 버튼을 누르세요.\r\r게임준비 단계에선 우측의 함선을 좌측의 자신의 전장에 끌어다 놓으세요.\r인접하게는 배치할 수 없습니다.\r드래그중 우클릭으로 방향을 전환할 수 있습니다.\r 배치완료후 준비버튼을 누르세요.\r\r게임시작수 순서는 랜덤입니다.\r상대의 배가 있을 곳을 포격하세요. 상대를 비격시키면 연속해서 공격할 수 있습니다.\r하단 버튼으로 아이템을 사용할 수 있습니다.");
        }

        private void InsertIpTextBox_TextChanged(object sender, EventArgs e)
        {
            if(thismode==0 && InsertIpTextBox.Text =="")
                btnJoinGame.Enabled = false;
            else if (thismode == 0 && InsertIpTextBox.Text != "")
                btnJoinGame.Enabled = true;
        }

        private void tmrretry_Tick(object sender, EventArgs e)
        {
            if(gameretry==1)
            {
                endPanel.Location = new Point(0, 650);
                Setpanel.Location = new Point(0, 0);
                gameretry = 0;
                tmrretry.Enabled = false;
                gamemode= 1;
            }
        }

    }
}
