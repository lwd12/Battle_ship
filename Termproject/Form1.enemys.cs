using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Termproject.Properties;

namespace Termproject
{
    public partial class Form1
    {
        Point MyCannonballResetPoint = new Point(-50, 275);                                       //내 캐논 발사 마우스 클릭 좌표를 수신 좌표로 변경하여 적 캐논 발사로 변경
        Point EnemmyCannonballResetPoint = new Point(1250, 275);
        public bool torpedoready = false;
        public bool bombready = false;
        public int torpedoleft = 2, torpedostartline, torpedoline, enemytorpedoline=9;
        public int bombleft = 2;
        double dx, dy, cannonballx, cannonbally;
        int targetx, targety;
        int mybombhit;
        int cannonhit;
        int enemybombhit;

        public void myturn()
        {
            tmrmygraphic.Enabled = false;
            enemytorpedoline = 9;
            enemyattacking = 0;
            gameturn = 0; //내턴됨
            enemyfield.Enabled = true;//내턴됨
            arrow.Image = Properties.Resources.flagright;
            CrossHorizontal.BringToFront();
            CrossVertical.BringToFront();
            if (torpedoleft > 0 && gameturn == 0)
                btntorpedo.Enabled = true;
            else
                btntorpedo.Enabled = false;

            if (bombleft > 0 && gameturn == 0)
                btnbomb.Enabled = true;
            else
                btnbomb.Enabled = false;
        }
        public void enemyturn()
        {
            tmrmygraphic.Enabled = true;
            enemytorpedoline = 9;
            btnbomb.Enabled = false;
            btntorpedo.Enabled= false;
            gameturn = 1;
            CrossHorizontal.Visible = false;
            CrossVertical.Visible = false;
            enemyfield.Enabled = false;
            arrow.Image = Properties.Resources.flagleft;
            streamWriter1.WriteLine("turnend");
        }
        private void tmrmytorpedo_Tick(object sender, EventArgs e)
        {
            enemyfieldcheck();
            if (torpedoline >= 10)
            {
                tmrmytorpedo.Enabled = false;
                enemyturn();
                return;
            }
            if (enemyfielddata[torpedoline,torpedostartline,0]==1)
            {
                enemyfielddata[torpedoline, torpedostartline, 0] = 3;
                enemyfield.Enabled = true;
                enemyfieldcheck();
                myturn();
                enemygraphic();
                tmrmytorpedo.Enabled = false;
                return;

            }
            else if(enemyfielddata[torpedoline, torpedostartline, 0] ==0)
            {
                enemyfielddata[torpedoline, torpedostartline, 0] = 2;
            }
            torpedoline++;
            enemygraphic();
        }
        private void tmrmygraphic_Tick(object sender, EventArgs e)
        {
            if (enemyattacking == 1 && gamemode==2)
            {
                if (int.Parse(enemyattack[2]) == 1) //어뢰
                {
                    torpedostartline = int.Parse(enemyattack[1]);
                    myfieldcheck();
                    if (enemytorpedoline < 0)
                    {
                        myturn();
                        return;
                    }
                    if (myfielddata[enemytorpedoline, torpedostartline, 0] == 1)
                    {
                        myfielddata[enemytorpedoline, torpedostartline, 0] = 3;
                        myfieldcheck();
                        mygraphic();
                        enemytorpedoline = 9;
                        enemyattacking = 0;
                        return;

                    }
                    else if (myfielddata[enemytorpedoline, torpedostartline, 0] == 0)
                    {
                        myfielddata[enemytorpedoline, torpedostartline, 0] = 2;
                    }
                    mygraphic();
                    enemytorpedoline--;
                }
                else if (int.Parse(enemyattack[2]) == 2) //폭탄
                {
                    enemybombhit = 0;
                    for (int xx = 0; xx < 3; xx++)
                    {
                        for (int yy = 0; yy < 3; yy++)
                        {
                            if (myfielddata[int.Parse(enemyattack[0]) + xx, int.Parse(enemyattack[1]) + yy, 0] == 1)
                            {
                                myfielddata[int.Parse(enemyattack[0]) + xx, int.Parse(enemyattack[1]) + yy, 0] = 3;
                                mybombhit++;
                            }
                            else if (myfielddata[int.Parse(enemyattack[0]) + xx, int.Parse(enemyattack[1]) + yy, 0] == 0)
                                myfielddata[int.Parse(enemyattack[0]) + xx, int.Parse(enemyattack[1]) + yy, 0] = 2;
                        }
                    }
                    myfieldcheck();
                    bombleft--;
                    if (mybombhit == 0)
                    {
                        myturn();
                    }
                    else
                    {
                        enemyturn();
                    }
                    mygraphic();
                    timer2.Enabled = true;
                    enemyattacking = 0;
                }
                else if (int.Parse(enemyattack[2]) == 0)//포
                {
                    cannonhit = 0;
                    if (myfielddata[int.Parse(enemyattack[0]), int.Parse(enemyattack[1]), 0] == 1)
                    {
                        myfielddata[int.Parse(enemyattack[0]), int.Parse(enemyattack[1]), 0] = 3;
                        cannonhit++;
                    }
                    else if (myfielddata[int.Parse(enemyattack[0]), int.Parse(enemyattack[1]), 0] == 0)
                    {
                        myfielddata[int.Parse(enemyattack[0]), int.Parse(enemyattack[1]), 0] = 2;
                    }
                    else if (myfielddata[int.Parse(enemyattack[0]), int.Parse(enemyattack[1]), 0] == 2)
                    {
                        return;
                    }
                    myfieldcheck();
                    if (cannonhit == 0)
                    {
                        myturn();
                    }
                    mygraphic();
                    timer2.Enabled = true;
                    enemyattacking = 0;
                }

                if (torpedoleft > 0 && gameturn == 0)
                    btntorpedo.Enabled = true;
                else
                    btntorpedo.Enabled = false;
                if (bombleft > 0 && gameturn == 0)
                    btnbomb.Enabled = true;
                else
                    btnbomb.Enabled = false;
                torpedoready = false;
                bombready = false;
            }
        }

        private void enemyfield_Click(object sender, EventArgs e)
        {
            CrossHorizontal.Visible = false;
            CrossVertical.Visible = false;
            enemyfield.Enabled = false;
            bombsight.Visible = false;
            cursornow(out int x, out int y);
            if (torpedoready == true) //어뢰
            {
                torpedostartline = (CrossHorizontal.Location.Y - enemyfield.Location.Y)/50;
                torpedoline = 0;
                tmrmytorpedo.Enabled= true;
                CrossHorizontal.Visible = false;
                CrossVertical.Visible = false;
                enemyfield.Enabled = false;
                streamWriter1.WriteLine("0/"+torpedostartline+"/1");
                torpedoleft--;
            }
            else if (bombready == true) //폭탄
            {
                bombsight.Visible = false;
                mybombhit = 0;
                for (int xx = 0; xx < 3; xx++)
                {
                    for (int yy = 0; yy < 3; yy++)
                    {
                        if (enemyfielddata[(bombsight.Location.X - enemyfield.Location.X) / 50 + xx, (bombsight.Location.Y - enemyfield.Location.Y) / 50 + yy, 0] == 1)
                        {
                            enemyfielddata[(bombsight.Location.X - enemyfield.Location.X) / 50 + xx, (bombsight.Location.Y - enemyfield.Location.Y) / 50 + yy, 0] = 3;
                            mybombhit++;
                        }
                        else if (enemyfielddata[(bombsight.Location.X - enemyfield.Location.X) / 50 + xx, (bombsight.Location.Y - enemyfield.Location.Y) / 50 + yy, 0] == 0)
                            enemyfielddata[(bombsight.Location.X - enemyfield.Location.X) / 50 + xx, (bombsight.Location.Y - enemyfield.Location.Y) / 50 + yy, 0] = 2;
                    }
                }
                streamWriter1.WriteLine((bombsight.Location.X - enemyfield.Location.X) / 50 + "/" + (bombsight.Location.Y - enemyfield.Location.Y) / 50 + "/2");
                enemyfieldcheck();
                enemygraphic();
                bombleft--;
                if (mybombhit == 0)
                {
                    enemyturn();
                    enemygraphic();
                }
                else
                {
                    myturn();
                    mygraphic();
                }

                if (torpedoleft > 0 && gameturn == 0)
                    btntorpedo.Enabled = true;
                else
                    btntorpedo.Enabled = false;
                if (bombleft > 0 && gameturn == 0)
                    btnbomb.Enabled = true;
                else
                    btnbomb.Enabled = false;
                torpedoready = false;
                bombready = false;
            }
            else //포
            {
                cannonhit = 0;
                if (enemyfielddata[(x - enemyfield.Location.X) / 50, (y - enemyfield.Location.Y) / 50, 0] == 1)
                {
                    enemyfielddata[(x - enemyfield.Location.X) / 50, (y - enemyfield.Location.Y) / 50, 0] = 3;
                    streamWriter1.WriteLine((x - enemyfield.Location.X) / 50 + "/" + (y - enemyfield.Location.Y) / 50 + "/0");
                    cannonhit++;
                }
                else if (enemyfielddata[(x - enemyfield.Location.X) / 50, (y - enemyfield.Location.Y) / 50, 0] == 0)
                {
                    enemyfielddata[(x - enemyfield.Location.X) / 50, (y - enemyfield.Location.Y) / 50, 0] = 2;
                    streamWriter1.WriteLine((x - enemyfield.Location.X) / 50 + "/" + (y - enemyfield.Location.Y) / 50 + "/0");
                }
                else
                {
                    myturn();
                    return;
                }
                enemyfieldcheck(); //enemyfielddata();
                enemygraphic();
                if (cannonhit == 0)
                {
                    enemyturn();
                    enemygraphic();
                }
                else
                {
                    myturn();
                    mygraphic();
                }
            }

            if (torpedoleft > 0 && gameturn==0)
                btntorpedo.Enabled = true;
            else
                btntorpedo.Enabled = false;
            if (bombleft > 0 && gameturn == 0)
                btnbomb.Enabled = true;
            else
                btnbomb.Enabled = false;
            torpedoready = false;
            bombready = false;

        }

        private void enemyfield_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled=false;
            if (torpedoready == true)
            {
                CrossHorizontal.Visible = true;
                cursornow(out int x, out int y);
                x = (x - enemyfield.Location.X) / 50 * 50 + enemyfield.Location.X;
                y = (y - enemyfield.Location.Y) / 50 * 50 + enemyfield.Location.Y;
                CrossHorizontal.Location = new Point(enemyfield.Location.X, y);
            }
            else if (bombready == true)
            {
                bombsight.Visible = true;
                cursornow(out int x, out int y);
                x = ((x - enemyfield.Location.X) / 50 - 1) * 50 + enemyfield.Location.X;
                y = ((y - enemyfield.Location.Y) / 50 - 1) * 50 + enemyfield.Location.Y;
                if (x < enemyfield.Location.X)
                    x = enemyfield.Location.X;
                if (x > enemyfield.Location.X + enemyfield.Width - bombsight.Width)
                    x = enemyfield.Location.X + enemyfield.Width - bombsight.Width;
                if (y < enemyfield.Location.Y)
                    y = enemyfield.Location.Y;
                if (y > enemyfield.Location.Y + enemyfield.Height - bombsight.Height)
                    y = enemyfield.Location.Y + enemyfield.Height - bombsight.Height;
                bombsight.Location = new Point(x, y);
            }
            else if (torpedoready == false && bombready == false)
            {
                CrossVertical.Visible = true;
                CrossHorizontal.Visible = true;
                cursornow(out int x, out int y);
                x = (x - enemyfield.Location.X) / 50 * 50 + enemyfield.Location.X;
                y = (y - enemyfield.Location.Y) / 50 * 50 + enemyfield.Location.Y;
                CrossVertical.Location = new Point(x, enemyfield.Location.Y);
                CrossHorizontal.Location = new Point(enemyfield.Location.X, y);
            }
        }

        private void enemyfield_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CrossVertical.Visible = false;
            CrossHorizontal.Visible = false;
            bombsight.Visible = false;
        }

        private void btntorpedo_Click(object sender, EventArgs e)
        {
            if (torpedoready == false && gameturn==0)
            {
                torpedoready = true;
                btnbomb.Enabled = false;
            }
            else if (torpedoready == true && gameturn == 0)
            {
                torpedoready = false;
                if(bombleft>0)
                    btnbomb.Enabled = true;
            }
        }

        private void btnbomb_Click(object sender, EventArgs e)
        {
            if (bombready == false && gameturn == 0)
            {
                bombready = true;
                btntorpedo.Enabled = false;
            }
            else if (bombready == true && gameturn == 0)
            {
                bombready = false;
                if(torpedoleft>0)
                    btntorpedo.Enabled = true;
            }
        }
        public void capturetest(PictureBox pic) //내필드 적필드 캡처 갱신
        {
            int x = pic.Location.X;
            int y = pic.Location.Y;


            // 화면 크기 가져오기
            Rectangle screenBound = new Rectangle(x, y, 500, 500);
            // Bitmap 객체 생성
            Bitmap screenshot = new Bitmap(screenBound.Width, screenBound.Height);

            // //enemygraphics 객체 생성
            using (Graphics a = Graphics.FromImage(screenshot))
            {
                // 화면 캡처
                a.CopyFromScreen(PointToScreen(new Point(screenBound.X, screenBound.Y)), new Point(0, 0), screenshot.Size);
            }

            pic.Image = screenshot;

        }
        public void enemyfieldcheck()
        {
            for (int ii = 1; ii <= 10; ii++)
                shipservive[ii] = 0;

            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if(enemyfielddata[ii, jj, 0]==3)
                    {
                        for (int kk = 1; kk <= 10; kk++) //shipnumber
                        { 
                            if(enemyfielddata[ii, jj, 1] == kk)
                            {
                                shipservive[kk]++;
                            }
                        }
                    }
                }
            }

            for (int shipnum = 1; shipnum <= 10; shipnum++)
            {
                int shiplong=0;
                if (shipnum == 1)
                    shiplong = 4;
                if (shipnum > 1 && shipnum <= 3)
                    shiplong = 3;
                if (shipnum > 3 && shipnum <= 6)
                    shiplong = 2;
                if (shipnum > 6)
                    shiplong = 1;

                if (shipservive[shipnum] == shiplong) //ship14 격침
                {
                    for (int ii = 0; ii < 10; ii++)
                    {
                        for (int jj = 0; jj < 10; jj++)
                        {
                            if (enemyfielddata[ii, jj, 1] == shipnum)
                            {
                                enemyfielddata[ii, jj, 0] = 4;
                            }
                        }
                    }
                }
            }

            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (enemyfielddata[ii, jj,0] != 4)
                    {
                        for (int zz = -1; zz < 2; zz++)
                        {
                            for (int xx = -1; xx < 2; xx++)
                            {
                                if (ii + zz >= 0 && jj + xx >= 0 && ii + zz < 10 && jj + xx < 10)
                                {
                                    if (enemyfielddata[ii + zz, jj + xx,0] == 4)
                                    {
                                        if (enemyfielddata[ii, jj,0] == 0)
                                            enemyfielddata[ii, jj,0] = 2;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            gameover();
        }

        public void myfieldcheck()
        {
            for (int ii = 0; ii < 11; ii++)
                shipservive[ii] = 0;
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (myfielddata[ii, jj, 0] == 3)
                    {
                        for (int kk = 1; kk <= 10; kk++) //shipnumber
                        {
                            if (myfielddata[ii, jj, 1] == kk)
                            {
                                shipservive[kk]++;
                            }
                        }
                    }
                }
            }

            for (int shipnum = 1; shipnum <= 10; shipnum++)
            {
                int shiplong = 0;
                if (shipnum == 1)
                    shiplong = 4;
                if (shipnum > 1 && shipnum <= 3)
                    shiplong = 3;
                if (shipnum > 3 && shipnum <= 6)
                    shiplong = 2;
                if (shipnum > 6)
                    shiplong = 1;

                if (shipservive[shipnum] == shiplong) //ship14 격침
                {
                    for (int ii = 0; ii < 10; ii++)
                    {
                        for (int jj = 0; jj < 10; jj++)
                        {
                            if (myfielddata[ii, jj, 1] == shipnum)
                            {
                                myfielddata[ii, jj, 0] = 4;
                            }
                        }
                    }
                }
            }
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (myfielddata[ii, jj, 0] != 4)
                    {
                        for (int zz = -1; zz < 2; zz++)
                        {
                            for (int xx = -1; xx < 2; xx++)
                            {
                                if (ii + zz >= 0 && jj + xx >= 0 && ii + zz < 10 && jj + xx < 10)
                                {
                                    if (myfielddata[ii + zz, jj + xx, 0] == 4)
                                    {
                                        if (myfielddata[ii, jj, 0] == 0)
                                            myfielddata[ii, jj, 0] = 2;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            gameover();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
                enemygraphic();
            timer1.Enabled = false;
        }

        public void enemygraphic()
        {
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (enemyfielddata[ii, jj, 0] == 2)
                    {
                        imgmiss.BringToFront();
                        imgmiss.Location = new Point(enemyfield.Location.X + ii * 50, enemyfield.Location.Y + jj * 50);
                        capturetest(enemyfield);
                    }
                    if (enemyfielddata[ii, jj, 0] == 3)
                    {
                        imghit.BringToFront();
                        imghit.Location = new Point(enemyfield.Location.X + ii * 50, enemyfield.Location.Y + jj * 50);
                        capturetest(enemyfield);
                    }
                    if (enemyfielddata[ii, jj, 0] == 4)
                    {
                        imghit.BringToFront();
                        imghit.Location = new Point(enemyfield.Location.X + ii * 50, enemyfield.Location.Y + jj * 50);
                        capturetest(enemyfield);
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int counter = 0;
            while (counter < 3)
            {
                mygraphic();
                counter++;
            }
            timer2.Enabled = false;
        }
        public void mygraphic()
        {
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (myfielddata[ii, jj, 0] == 2)
                    {
                        imgmiss.BringToFront();
                        imgmiss.Location = new Point(myfield.Location.X + ii * 50, myfield.Location.Y + jj * 50);
                        capturetest(myfield);
                    }
                    if (myfielddata[ii, jj, 0] == 3)
                    {
                        imghit.BringToFront();
                        imghit.Location = new Point(myfield.Location.X + ii * 50, myfield.Location.Y + jj * 50);
                        capturetest(myfield);
                    }
                    if (myfielddata[ii, jj, 0] == 4)
                    {
                        imghit.BringToFront();
                        imghit.Location = new Point(myfield.Location.X + ii * 50, myfield.Location.Y + jj * 50);
                        capturetest(myfield);
                    }
                }
            }
        }

        public void gameover()
        {
            int myserviver = 0, enemyserviver = 0;
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (myfielddata[ii, jj, 0] == 1)
                        myserviver++;
                    if (enemyfielddata[ii, jj, 0] == 1)
                        enemyserviver++;
                }
            }
            if (myserviver == 0)
            {
                gamemode = 3;
                enemyattacking = 0;
                tmrmytorpedo.Enabled = false;
                tmrmygraphic.Enabled = false;
                arrow.Location = new Point(1250, 300);
                endPanel.BringToFront();
                endPanel.Location = new Point(0, 0);
                endPanel.Size = new Size(1250, 650);
                endPanel.Visible = true;
                Setpanel.Location = new Point(1250, 650);
                labelresult.Text = "전투 패배";
            }
            if (enemyserviver == 0)
            {
                gamemode = 3;
                enemyattacking = 0;
                tmrmytorpedo.Enabled = false;
                tmrmygraphic.Enabled = false;
                arrow.Location = new Point(1250, 300);
                endPanel.BringToFront();
                endPanel.Location = new Point(0, 0);
                endPanel.Size = new Size(1250, 650);
                endPanel.Visible = true;
                Setpanel.Location = new Point(1250, 650);
                labelresult.Text = "전투 승리 !";
            }
        }
    }
}
