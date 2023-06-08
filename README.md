BATTLE_SHIP_GAME
=============
It is a game that is based on the traditional American game Battleship and has been upgraded.


## Function   
> The rules are the same as the traditional game of Battleship.   
> Two types of bomb items and an airplane item have been added.   
> It operates through socket communication and is a 1v1 game.

## Img  
<img src="/login.png" width="50%" height="40%" title="px(픽셀) 크기 설정" alt="login"></img></br>

Inside the loop, use StreamReader to read a line of data from the server (receiveData1 = streamReader1.ReadLine()).
You can compare the received data with different conditions using if statements:

* If the received data is "shutdown", terminate the client connection.
* If the received data is "turnend", call the myturn() function.
```C#
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
```

* If the gamemode is 0, perform different actions based on specific conditions.
* If the gamemode is 1, process the map data transmitted from the server.
* If the gamemode is 2, handle the data values for the selected position during the game.
* If the gamemode is 3, perform the necessary processing for game restart.

```C#
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
```
<img src="/setting.png" width="50%" height="40%" title="px(픽셀) 크기 설정" alt="setting"></img></br>
<img src="/shadow.png" width="50%" height="40%" title="px(픽셀) 크기 설정" alt="shadow"></img></br>
<img src="/mouse_event.png" width="50%" height="40%" title="px(픽셀) 크기 설정" alt="mouse_event"></img></br>

The enemyfield_MouseMove function is called when the mouse moves within the enemyfield area.   
Call the cursornow function to retrieve the current mouse position.   
Adjust the position of the CrossHorizontal control based on that location.

```C#
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

```
<img src="/detect.png" width="50%" height="40%" title="px(픽셀) 크기 설정" alt="detect"></img></br>


