using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termproject
{
    public partial class Form1
    {
        public bool ship14drag = false;
        public bool ship13_1drag = false;
        public bool ship13_2drag = false;
        public bool ship12_1drag = false;
        public bool ship12_2drag = false;
        public bool ship12_3drag = false;
        public bool ship11_1drag = false;
        public bool ship11_2drag = false;
        public bool ship11_3drag = false;
        public bool ship11_4drag = false;
        Point ship14reset = new Point(650, 50);
        Point ship13_1reset = new Point(650, 150);
        Point ship13_2reset = new Point(850, 150);
        Point ship12_1reset = new Point(650, 250);
        Point ship12_2reset = new Point(800, 250);
        Point ship12_3reset = new Point(950, 250);
        Point ship11_1reset = new Point(650, 350);
        Point ship11_2reset = new Point(750, 350);
        Point ship11_3reset = new Point(850, 350);
        Point ship11_4reset = new Point(950, 350);
        public int shipdirection;
        public void cursornow(out int x, out int y) //use this "cursornow(out int x, out int y);"
        {
            Point mousepos = new Point(Cursor.Position.X, Cursor.Position.Y);
            Point mousepostoclient = this.PointToClient(mousepos);
            x = mousepostoclient.X;
            y = mousepostoclient.Y;
        }
        public void myfieldset()
        {
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (myfieldsetting[ii, jj,0] == 0)
                    {
                        for (int zz = -1; zz < 2; zz++)
                        {
                            for (int xx = -1; xx < 2; xx++)
                            {
                                if (ii + zz >= 0 && jj + xx >= 0)
                                    if (myfieldsetting[ii + zz, jj + xx,0] == 1)
                                        myfieldsetting[ii, jj,0] = 2;
                            }
                        }
                    }
                }
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if (ship14.Enabled == false)
                shipsready[0] = 1;
            if (ship13_1.Enabled == false)
                shipsready[1] = 1;
            if (ship13_2.Enabled == false)
                shipsready[2] = 1;
            if (ship12_1.Enabled == false)
                shipsready[3] = 1;
            if (ship12_2.Enabled == false)
                shipsready[4] = 1;
            if (ship12_3.Enabled == false)
                shipsready[5] = 1;
            if (ship11_1.Enabled == false)
                shipsready[6] = 1;
            if (ship11_2.Enabled == false)
                shipsready[7] = 1;
            if (ship11_3.Enabled == false)
                shipsready[8] = 1;
            if (ship11_4.Enabled == false)
                shipsready[9] = 1;
            for (int ii = 0; ii < 10; ii++)
            {
                if (shipsready[ii] != 1)
                {
                    labelready.Text = "배치되지 않은 함선이 있습니다.";
                    return;
                }
            }
            labelready.Text = "상대의 준비를 대기중";
            btnReset.Enabled = false;
            btnReady.Enabled = false;

            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (myfieldsetting[ii, jj, 0] == 1)
                    {
                        myfielddata[ii, jj, 0] = 1;
                        myfielddata[ii, jj, 1] = myfieldsetting[ii, jj, 1];
                    }
                    else
                    {
                        myfielddata[ii, jj, 0] = 0;
                        myfielddata[ii, jj, 1] = 0;
                    }
                }
            }

            string sendmymapdata = "";//클라로 송신
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    if (myfieldsetting[ii, jj, 0] == 1)
                        sendmymapdata += "1" + "/";
                    else
                        sendmymapdata += "0" + "/";
                    sendmymapdata += myfieldsetting[ii, jj, 1] + "/";
                }
            }
            streamWriter1.WriteLine(sendmymapdata);
            capturetest(myfield);
            ship14.Visible = false;
            ship13_1.Visible = false;
            ship13_2.Visible = false;
            ship12_1.Visible = false;
            ship12_2.Visible = false;
            ship12_3.Visible = false;
            ship11_1.Visible = false;
            ship11_2.Visible = false;
            ship11_3.Visible = false;
            ship11_4.Visible = false;
        }
        private void reset_Click(object sender, EventArgs e)
        {
            for (int ii = 0; ii < 10; ii++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    myfieldsetting[ii, jj,0] = 0;
                    myfieldsetting[ii, jj,1] = 0;
                }
            }
            ship14.Location = ship14reset;
            ship13_1.Location = ship13_1reset;
            ship13_2.Location = ship13_2reset;
            ship12_1.Location = ship12_1reset;
            ship12_2.Location = ship12_2reset;
            ship12_3.Location = ship12_3reset;
            ship11_1.Location = ship11_1reset;
            ship11_2.Location = ship11_2reset;
            ship11_3.Location = ship11_3reset;
            ship11_4.Location = ship11_4reset;
            ship14.Enabled = true;
            ship13_1.Enabled = true;
            ship13_2.Enabled = true;
            ship12_1.Enabled = true;
            ship12_2.Enabled = true;
            ship12_3.Enabled = true;
            ship11_1.Enabled = true;
            ship11_2.Enabled = true;
            ship11_3.Enabled = true;
            ship11_4.Enabled = true;
            ship14.Visible = true;
            ship13_1.Visible = true;
            ship13_2.Visible = true;
            ship12_1.Visible = true;
            ship12_2.Visible = true;
            ship12_3.Visible = true;
            ship11_1.Visible = true;
            ship11_2.Visible = true;
            ship11_3.Visible = true;
            ship11_4.Visible = true;
            ship14.Size = new Size(200, 50);
            ship13_1.Size = new Size(150, 50);
            ship13_2.Size = new Size(150, 50);
            ship12_1.Size = new Size(100, 50);
            ship12_2.Size = new Size(100, 50);
            ship12_3.Size = new Size(100, 50);
            ship14.Image = Properties.Resources.ship14;
            ship13_1.Image = Properties.Resources.ship13;
            ship13_2.Image = Properties.Resources.ship13;
            ship12_1.Image = Properties.Resources.ship12;
            ship12_2.Image = Properties.Resources.ship12;
            ship12_3.Image = Properties.Resources.ship12;

            enemyfield.Location = new Point(1250, 650);
            enemyfield.Image = Properties.Resources.pan;
            myfield.Image = Properties.Resources.pan;
            imghit.Location = new Point(1250, 0);
            imgmiss.Location = new Point(1250, 50);
            boom.Location = new Point(1250, 100);
            btnReady.Location = new Point(850, 450);
            btnReset.Location = new Point(650, 450);
            labelready.Location = new Point(1038, 493);
            tmrretry.Enabled = true;
            tmrmygraphic.Enabled = true;

            torpedoleft = 2;
            bombleft= 2;
            btntorpedo.Location = new Point(0, 650);
            btnbomb.Location = new Point(150, 650);
            btnReset.Enabled = true;
            btnReady.Enabled = true;
            labelready.Visible= true;

            for (int ii = 0; ii < 10; ii++)
                shipsready[ii] = 0;
        }

        private void button1_Click(object sender, EventArgs e) ///////////////////승리버튼 이엇던것
        {
            endPanel.Visible = true;
            endPanel.Location = new Point(0, 0);
            if (control != null) Setpanel.Controls.Remove(control);

        }

        private void retry_Click(object sender, EventArgs e)
        {
            btnretry.Enabled = false;
            streamWriter1.WriteLine("retry");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ship14_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship14.BringToFront();
                ship14drag = true;
                shadow14.Size = new Size(ship14.Width, ship14.Height);
            }
            else if (ship14drag == true && e.Button == MouseButtons.Right)
            {
                ship14.Size = new Size(ship14.Height, ship14.Width);
                shadow14.Size = new Size(shadow14.Height, shadow14.Width);
            }
            ship14.Location = new Point(x - ship14.Height / 2, y - ship14.Height / 2);
        }

        private void ship14_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship14drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow14.Visible = true;
                    shadow14.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    shipdirection = ship14.Width > ship14.Height ? 0 : 1; //0가로 1세로

                    if ((shipdirection == 0 && (x - myfield.Location.X) / 50 > 6) || (shipdirection == 1 && (y - myfield.Location.Y) / 50 > 6))
                        shadow14.BackColor = Color.Red;
                    else
                    {
                        if (shipdirection == 0)
                        {
                            ship14.Image = Properties.Resources.ship14;
                            for (int ii = 0; ii < 4; ii++)
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50 + ii, (y - myfield.Location.Y) / 50,0] != 0)
                                {
                                    shadow14.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow14.BackColor = Color.Lime;
                            }
                        }
                        else if (shipdirection == 1)
                        {
                            ship14.Image = Properties.Resources.ship14up;
                            for (int ii = 0; ii < 4; ii++)
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + ii,0] != 0)
                                {
                                    shadow14.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow14.BackColor = Color.Lime;
                            }
                        }

                    }
                }
                else
                {
                    shadow14.Visible = false;
                    shadow14.BackColor = Color.Red;
                }
                x -= ship14.Width > ship14.Height ? ship14.Height / 2 : ship14.Width / 2;
                y -= ship14.Width > ship14.Height ? ship14.Height / 2 : ship14.Width / 2;
                ship14.Location = new Point(x, y);
            }

        }

        private void ship14_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship14drag = false;
                shadow14.Visible = false;
                cursornow(out int x, out int y);
                if (shadow14.BackColor != Color.Red)
                {
                    ship14.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    if (shipdirection == 0)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 2, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 3, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 1] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 2, (y - myfield.Location.Y) / 50, 1] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 3, (y - myfield.Location.Y) / 50, 1] = 1;
                    }
                    else if (shipdirection == 1)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 2, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 3, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50,1] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1,1] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 2,1] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 3,1] = 1;
                    }
                    ship14.Enabled = false;
                    myfieldset();
                }
                else
                {
                    ship14.Location = ship14reset;
                    ship14.Size = new Size(200, 50);
                }
            }
        }
        /// <summary>
        /// ship13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ship13_1_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship13_1.BringToFront();
                ship13_1drag = true;
                shadow13.Size = new Size(ship13_1.Width, ship13_1.Height);
            }
            else if (ship13_1drag == true && e.Button == MouseButtons.Right)
            {
                ship13_1.Size = new Size(ship13_1.Height, ship13_1.Width);
                shadow13.Size = new Size(shadow13.Height, shadow13.Width);
            }
            ship13_1.Location = new Point(x - ship13_1.Height / 2, y - ship13_1.Height / 2);
        }

        private void ship13_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship13_1drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow13.Visible = true;
                    shadow13.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    shipdirection = ship13_1.Width > ship13_1.Height ? 0 : 1; //0가로 1세로

                    if ((shipdirection == 0 && (x - myfield.Location.X) / 50 > 7) || (shipdirection == 1 && (y - myfield.Location.Y) / 50 > 7)) //숫자 길이에 맞게 수정하기
                        shadow13.BackColor = Color.Red;
                    else
                    {
                        if (shipdirection == 0)
                        {
                            ship13_1.Image = Properties.Resources.ship13;
                            for (int ii = 0; ii < 3; ii++) //숫자 길이에 맞게 수정하기
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50 + ii, (y - myfield.Location.Y) / 50,0] != 0)
                                {
                                    shadow13.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow13.BackColor = Color.Lime;
                            }
                        }
                        else if (shipdirection == 1)
                        {
                            ship13_1.Image = Properties.Resources.ship13up;
                            for (int ii = 0; ii < 3; ii++)
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + ii,0] != 0)
                                {
                                    shadow13.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow13.BackColor = Color.Lime;
                            }
                        }

                    }
                }
                else
                {
                    shadow13.Visible = false;
                    shadow13.BackColor = Color.Red;
                }
                x -= ship13_1.Width > ship13_1.Height ? ship13_1.Height / 2 : ship13_1.Width / 2;
                y -= ship13_1.Width > ship13_1.Height ? ship13_1.Height / 2 : ship13_1.Width / 2;
                ship13_1.Location = new Point(x, y);
            }

        }

        private void ship13_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship13_1drag = false;
                shadow13.Visible = false;
                cursornow(out int x, out int y);
                if (shadow13.BackColor != Color.Red)
                {
                    ship13_1.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    if (shipdirection == 0)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 2, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 2; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 1] = 2;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 2, (y - myfield.Location.Y) / 50, 1] = 2;
                    }
                    else if (shipdirection == 1)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 2, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 2;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 1] = 2;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 2, 1] = 2;
                    }
                    ship13_1.Enabled = false;
                    myfieldset();
                }
                else
                {
                    ship13_1.Location = ship13_1reset;
                    ship13_1.Size = new Size(150, 50);
                }
            }
        }

        private void ship13_2_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship13_2.BringToFront();
                ship13_2drag = true;
                shadow13.Size = new Size(ship13_2.Width, ship13_2.Height);
            }
            else if (ship13_2drag == true && e.Button == MouseButtons.Right)
            {
                ship13_2.Size = new Size(ship13_2.Height, ship13_2.Width);
                shadow13.Size = new Size(shadow13.Height, shadow13.Width);
            }
            ship13_2.Location = new Point(x - ship13_2.Height / 2, y - ship13_2.Height / 2);
        }

        private void ship13_2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship13_2drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow13.Visible = true;
                    shadow13.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    shipdirection = ship13_2.Width > ship13_2.Height ? 0 : 1; //0가로 1세로

                    if ((shipdirection == 0 && (x - myfield.Location.X) / 50 > 7) || (shipdirection == 1 && (y - myfield.Location.Y) / 50 > 7)) //숫자 길이에 맞게 수정하기
                        shadow13.BackColor = Color.Red;
                    else
                    {
                        if (shipdirection == 0)
                        {
                            ship13_2.Image = Properties.Resources.ship13;
                            for (int ii = 0; ii < 3; ii++) //숫자 길이에 맞게 수정하기
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50 + ii, (y - myfield.Location.Y) / 50,0] != 0)
                                {
                                    shadow13.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow13.BackColor = Color.Lime;
                            }
                        }
                        else if (shipdirection == 1)
                        {
                            ship13_2.Image = Properties.Resources.ship13up;
                            for (int ii = 0; ii < 3; ii++)
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + ii,0] != 0)
                                {
                                    shadow13.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow13.BackColor = Color.Lime;
                            }
                        }

                    }
                }
                else
                {
                    shadow13.Visible = false;
                    shadow13.BackColor = Color.Red;
                }
                x -= ship13_2.Width > ship13_2.Height ? ship13_2.Height / 2 : ship13_2.Width / 2;
                y -= ship13_2.Width > ship13_2.Height ? ship13_2.Height / 2 : ship13_2.Width / 2;
                ship13_2.Location = new Point(x, y);
            }

        }

        private void ship13_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship13_2drag = false;
                shadow13.Visible = false;
                cursornow(out int x, out int y);
                if (shadow13.BackColor != Color.Red)
                {
                    ship13_2.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    if (shipdirection == 0)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 2, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 3; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 1] = 3;
                        myfieldsetting[(x - myfield.Location.X) / 50 + 2, (y - myfield.Location.Y) / 50, 1] = 3;
                    }
                    else if (shipdirection == 1)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 2, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 3;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 1] = 3;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 2, 1] = 3;
                    }
                    ship13_2.Enabled = false;
                    myfieldset();
                }
                else
                {
                    ship13_2.Location = ship13_2reset;
                    ship13_2.Size = new Size(150, 50);
                }
            }
        }
        /// <summary>
        /// ship12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ship12_1_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship12_1.BringToFront();
                ship12_1drag = true;
                shadow12.Size = new Size(ship12_1.Width, ship12_1.Height);
            }
            else if (ship12_1drag == true && e.Button == MouseButtons.Right)
            {
                ship12_1.Size = new Size(ship12_1.Height, ship12_1.Width);
                shadow12.Size = new Size(shadow12.Height, shadow12.Width);
            }
            ship12_1.Location = new Point(x - ship12_1.Height / 2, y - ship12_1.Height / 2);
        }

        private void ship12_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship12_1drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow12.Visible = true;
                    shadow12.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    shipdirection = ship12_1.Width > ship12_1.Height ? 0 : 1; //0가로 1세로

                    if ((shipdirection == 0 && (x - myfield.Location.X) / 50 > 8) || (shipdirection == 1 && (y - myfield.Location.Y) / 50 > 8)) //숫자 길이에 맞게 수정하기
                        shadow12.BackColor = Color.Red;
                    else
                    {
                        if (shipdirection == 0)
                        {
                            ship12_1.Image = Properties.Resources.ship12;
                            for (int ii = 0; ii < 2; ii++) //숫자 길이에 맞게 수정하기
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50 + ii, (y - myfield.Location.Y) / 50,0] != 0)
                                {
                                    shadow12.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow12.BackColor = Color.Lime;
                            }
                        }
                        else if (shipdirection == 1)
                        {
                            ship12_1.Image = Properties.Resources.ship12up;
                            for (int ii = 0; ii < 2; ii++)
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + ii,0] != 0)
                                {
                                    shadow12.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow12.BackColor = Color.Lime;
                            }
                        }

                    }
                }
                else
                {
                    shadow12.Visible = false;
                    shadow12.BackColor = Color.Red;
                }
                x -= ship12_1.Width > ship12_1.Height ? ship12_1.Height / 2 : ship12_1.Width / 2;
                y -= ship12_1.Width > ship12_1.Height ? ship12_1.Height / 2 : ship12_1.Width / 2;
                ship12_1.Location = new Point(x, y);
            }

        }

        private void ship12_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship12_1drag = false;
                shadow12.Visible = false;
                cursornow(out int x, out int y);
                if (shadow12.BackColor != Color.Red)
                {
                    ship12_1.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    if (shipdirection == 0)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 4; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 1] = 4;
                    }
                    else if (shipdirection == 1)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 4;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 1] = 4;
                    }
                    ship12_1.Enabled = false;
                    myfieldset();
                }
                else
                {
                    ship12_1.Location = ship12_1reset;
                    ship12_1.Size = new Size(100, 50);
                }
            }
        }

        private void ship12_2_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship12_2.BringToFront();
                ship12_2drag = true;
                shadow12.Size = new Size(ship12_2.Width, ship12_2.Height);
            }
            else if (ship12_2drag == true && e.Button == MouseButtons.Right)
            {
                ship12_2.Size = new Size(ship12_2.Height, ship12_2.Width);
                shadow12.Size = new Size(shadow12.Height, shadow12.Width);
            }
            ship12_2.Location = new Point(x - ship12_2.Height / 2, y - ship12_2.Height / 2);
        }

        private void ship12_2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship12_2drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow12.Visible = true;
                    shadow12.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    shipdirection = ship12_2.Width > ship12_2.Height ? 0 : 1; //0가로 1세로

                    if ((shipdirection == 0 && (x - myfield.Location.X) / 50 > 8) || (shipdirection == 1 && (y - myfield.Location.Y) / 50 > 8)) //숫자 길이에 맞게 수정하기
                        shadow12.BackColor = Color.Red;
                    else
                    {
                        if (shipdirection == 0)
                        {
                            ship12_2.Image = Properties.Resources.ship12;
                            for (int ii = 0; ii < 2; ii++) //숫자 길이에 맞게 수정하기
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50 + ii, (y - myfield.Location.Y) / 50,0] != 0)
                                {
                                    shadow12.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow12.BackColor = Color.Lime;
                            }
                        }
                        else if (shipdirection == 1)
                        {
                            ship12_2.Image = Properties.Resources.ship12up;
                            for (int ii = 0; ii < 2; ii++)
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + ii,0] != 0)
                                {
                                    shadow12.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow12.BackColor = Color.Lime;
                            }
                        }

                    }
                }
                else
                {
                    shadow12.Visible = false;
                    shadow12.BackColor = Color.Red;
                }
                x -= ship12_2.Width > ship12_2.Height ? ship12_2.Height / 2 : ship12_2.Width / 2;
                y -= ship12_2.Width > ship12_2.Height ? ship12_2.Height / 2 : ship12_2.Width / 2;
                ship12_2.Location = new Point(x, y);
            }

        }

        private void ship12_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship12_2drag = false;
                shadow12.Visible = false;
                cursornow(out int x, out int y);
                if (shadow12.BackColor != Color.Red)
                {
                    ship12_2.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    if (shipdirection == 0)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 5; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 1] = 5;
                    }
                    else if (shipdirection == 1)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 5;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 1] = 5;
                    }
                    ship12_2.Enabled = false;
                    myfieldset();
                }
                else
                {
                    ship12_2.Location = ship12_2reset;
                    ship12_2.Size = new Size(100, 50);
                }
            }
        }

        private void ship12_3_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship12_3.BringToFront();
                ship12_3drag = true;
                shadow12.Size = new Size(ship12_3.Width, ship12_3.Height);
            }
            else if (ship12_3drag == true && e.Button == MouseButtons.Right)
            {
                ship12_3.Size = new Size(ship12_3.Height, ship12_3.Width);
                shadow12.Size = new Size(shadow12.Height, shadow12.Width);
            }
            ship12_3.Location = new Point(x - ship12_3.Height / 2, y - ship12_3.Height / 2);
        }

        private void ship12_3_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship12_3drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow12.Visible = true;
                    shadow12.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    shipdirection = ship12_3.Width > ship12_3.Height ? 0 : 1; //0가로 1세로

                    if ((shipdirection == 0 && (x - myfield.Location.X) / 50 > 8) || (shipdirection == 1 && (y - myfield.Location.Y) / 50 > 8)) //숫자 길이에 맞게 수정하기
                        shadow12.BackColor = Color.Red;
                    else
                    {
                        if (shipdirection == 0)
                        {
                            ship12_3.Image = Properties.Resources.ship12;
                            for (int ii = 0; ii < 2; ii++) //숫자 길이에 맞게 수정하기
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50 + ii, (y - myfield.Location.Y) / 50,0] != 0)
                                {
                                    shadow12.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow12.BackColor = Color.Lime;
                            }
                        }
                        else if (shipdirection == 1)
                        {
                            ship12_3.Image = Properties.Resources.ship12up;
                            for (int ii = 0; ii < 2; ii++)
                            {
                                if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + ii,0] != 0)
                                {
                                    shadow12.BackColor = Color.Red;
                                    break;
                                }
                                else
                                    shadow12.BackColor = Color.Lime;
                            }
                        }

                    }
                }
                else
                {
                    shadow12.Visible = false;
                    shadow12.BackColor = Color.Red;
                }
                x -= ship12_3.Width > ship12_3.Height ? ship12_3.Height / 2 : ship12_3.Width / 2;
                y -= ship12_3.Width > ship12_3.Height ? ship12_3.Height / 2 : ship12_3.Width / 2;
                ship12_3.Location = new Point(x, y);
            }

        }

        private void ship12_3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship12_3drag = false;
                shadow12.Visible = false;
                cursornow(out int x, out int y);
                if (shadow12.BackColor != Color.Red)
                {
                    ship12_3.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    if (shipdirection == 0)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 6; //길이에 맞게 갯수 줄이기
                        myfieldsetting[(x - myfield.Location.X) / 50 + 1, (y - myfield.Location.Y) / 50, 1] = 6;
                    }
                    else if (shipdirection == 1)
                    {
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 0] = 1;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 6;
                        myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50 + 1, 1] = 6;
                    }
                    ship12_3.Enabled = false;
                    myfieldset();
                }
                else
                {
                    ship12_3.Location = ship12_3reset;
                    ship12_3.Size = new Size(100, 50);
                }
            }
        }
        /// <summary>
        /// ship11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ship11_1_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship11_1.BringToFront();
                ship11_1drag = true;
            }
            else if (ship11_1drag == true && e.Button == MouseButtons.Right)
            {
                ship11_1.Size = new Size(ship11_1.Height, ship11_1.Width);
            }
            ship11_1.Location = new Point(x - ship11_1.Height / 2, y - ship11_1.Height / 2);
        }

        private void ship11_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship11_1drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow11.Visible = true;
                    shadow11.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);

                    if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50,0] != 0)
                        shadow11.BackColor = Color.Red;
                    else
                        shadow11.BackColor = Color.Lime;
                }
                else
                {
                    shadow11.Visible = false;
                    shadow11.BackColor = Color.Red;
                }
                x -= ship11_1.Width > ship11_1.Height ? ship11_1.Height / 2 : ship11_1.Width / 2;
                y -= ship11_1.Width > ship11_1.Height ? ship11_1.Height / 2 : ship11_1.Width / 2;
                ship11_1.Location = new Point(x, y);
            }

        }

        private void ship11_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship11_1drag = false;
                shadow11.Visible = false;
                cursornow(out int x, out int y);
                if (shadow11.BackColor != Color.Red)
                {
                    ship11_1.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 7; //길이에 맞게 갯수 줄이기
                    ship11_1.Enabled = false;
                    myfieldset();
                }
                else
                    ship11_1.Location = ship11_1reset;
            }
        }

        private void ship11_2_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship11_2.BringToFront();
                ship11_2drag = true;
            }
            else if (ship11_2drag == true && e.Button == MouseButtons.Right)
            {
                ship11_2.Size = new Size(ship11_2.Height, ship11_2.Width);
            }
            ship11_2.Location = new Point(x - ship11_2.Height / 2, y - ship11_2.Height / 2);
        }

        private void ship11_2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship11_2drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {
                    shadow11.Visible = true;
                    shadow11.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);

                    if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50,0] != 0)
                        shadow11.BackColor = Color.Red;
                    else
                        shadow11.BackColor = Color.Lime;
                }
                else
                {
                    shadow11.Visible = false;
                    shadow11.BackColor = Color.Red;
                }
                x -= ship11_2.Width > ship11_2.Height ? ship11_2.Height / 2 : ship11_2.Width / 2;
                y -= ship11_2.Width > ship11_2.Height ? ship11_2.Height / 2 : ship11_2.Width / 2;
                ship11_2.Location = new Point(x, y);
            }

        }

        private void ship11_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship11_2drag = false;
                shadow11.Visible = false;
                cursornow(out int x, out int y);
                if (shadow11.BackColor != Color.Red)
                {
                    ship11_2.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 8; //길이에 맞게 갯수 줄이기
                    ship11_2.Enabled = false;
                    myfieldset();
                }
                else
                    ship11_2.Location = ship11_2reset;
            }
        }

        private void ship11_3_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship11_3.BringToFront();
                ship11_3drag = true;
            }
            else if (ship11_3drag == true && e.Button == MouseButtons.Right)
            {
                ship11_3.Size = new Size(ship11_3.Height, ship11_3.Width);
            }
            ship11_3.Location = new Point(x - ship11_3.Height / 2, y - ship11_3.Height / 2);
        }

        private void ship11_3_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship11_3drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow11.Visible = true;
                    shadow11.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);

                    if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50,0] != 0)
                        shadow11.BackColor = Color.Red;
                    else
                        shadow11.BackColor = Color.Lime;
                }
                else
                {
                    shadow11.Visible = false;
                    shadow11.BackColor = Color.Red;
                }
                x -= ship11_3.Width > ship11_3.Height ? ship11_3.Height / 2 : ship11_3.Width / 2;
                y -= ship11_3.Width > ship11_3.Height ? ship11_3.Height / 2 : ship11_3.Width / 2;
                ship11_3.Location = new Point(x, y);
            }

        }

        private void ship11_3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship11_3drag = false;
                shadow11.Visible = false;
                cursornow(out int x, out int y);
                if (shadow11.BackColor != Color.Red)
                {
                    ship11_3.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 9; //길이에 맞게 갯수 줄이기
                    ship11_3.Enabled = false;
                    myfieldset();
                }
                else
                    ship11_3.Location = ship11_3reset;
            }
        }

        private void ship11_4_MouseDown(object sender, MouseEventArgs e)
        {
            cursornow(out int x, out int y);
            if (e.Button == MouseButtons.Left)
            {
                ship11_4.BringToFront();
                ship11_4drag = true;
            }
            else if (ship11_4drag == true && e.Button == MouseButtons.Right)
            {
                ship11_4.Size = new Size(ship11_4.Height, ship11_4.Width);
            }
            ship11_4.Location = new Point(x - ship11_4.Height / 2, y - ship11_4.Height / 2);
        }

        private void ship11_4_MouseMove(object sender, MouseEventArgs e)
        {
            if (ship11_4drag == true)
            {
                cursornow(out int x, out int y);
                if (x >= myfield.Location.X && x <= myfield.Location.X + myfield.Width && y >= myfield.Location.Y && y <= myfield.Location.Y + myfield.Height) ///공사중
                {

                    shadow11.Visible = true;
                    shadow11.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);

                    if (myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50,0] != 0)
                        shadow11.BackColor = Color.Red;
                    else
                        shadow11.BackColor = Color.Lime;
                }
                else
                {
                    shadow11.Visible = false;
                    shadow11.BackColor = Color.Red;
                }
                x -= ship11_4.Width > ship11_4.Height ? ship11_4.Height / 2 : ship11_4.Width / 2;
                y -= ship11_4.Width > ship11_4.Height ? ship11_4.Height / 2 : ship11_4.Width / 2;
                ship11_4.Location = new Point(x, y);
            }

        }

        private void ship11_4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ship11_4drag = false;
                shadow11.Visible = false;
                cursornow(out int x, out int y);
                if (shadow11.BackColor != Color.Red)
                {
                    ship11_4.Location = new Point((x - myfield.Location.X) / 50 * 50 + myfield.Location.X, (y - myfield.Location.Y) / 50 * 50 + myfield.Location.Y);
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 0] = 1; //길이에 맞게 갯수 줄이기
                    myfieldsetting[(x - myfield.Location.X) / 50, (y - myfield.Location.Y) / 50, 1] = 10; //길이에 맞게 갯수 줄이기
                    ship11_4.Enabled = false;
                    myfieldset();
                }
                else
                    ship11_4.Location = ship11_4reset;
            }
        }
    }
}
