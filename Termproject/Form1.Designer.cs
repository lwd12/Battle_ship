using System.Drawing;

namespace Termproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Main = new System.Windows.Forms.Panel();
            this.endPanel = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnretry = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.Setpanel = new System.Windows.Forms.Panel();
            this.boom = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.imghit = new System.Windows.Forms.PictureBox();
            this.imgmiss = new System.Windows.Forms.PictureBox();
            this.CrossHorizontal = new System.Windows.Forms.Button();
            this.bombsight = new System.Windows.Forms.PictureBox();
            this.CrossVertical = new System.Windows.Forms.Button();
            this.enemyfield = new System.Windows.Forms.PictureBox();
            this.arrow = new System.Windows.Forms.PictureBox();
            this.btnbomb = new System.Windows.Forms.Button();
            this.btntorpedo = new System.Windows.Forms.Button();
            this.shadow11 = new System.Windows.Forms.Button();
            this.shadow12 = new System.Windows.Forms.Button();
            this.shadow13 = new System.Windows.Forms.Button();
            this.shadow14 = new System.Windows.Forms.Button();
            this.labelready = new System.Windows.Forms.Label();
            this.ship11_4 = new System.Windows.Forms.PictureBox();
            this.ship11_3 = new System.Windows.Forms.PictureBox();
            this.ship11_2 = new System.Windows.Forms.PictureBox();
            this.ship11_1 = new System.Windows.Forms.PictureBox();
            this.ship12_3 = new System.Windows.Forms.PictureBox();
            this.ship12_2 = new System.Windows.Forms.PictureBox();
            this.ship12_1 = new System.Windows.Forms.PictureBox();
            this.ship13_2 = new System.Windows.Forms.PictureBox();
            this.ship13_1 = new System.Windows.Forms.PictureBox();
            this.ship14 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.myfield = new System.Windows.Forms.PictureBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.question = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.labelipadress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertIpTextBox = new System.Windows.Forms.TextBox();
            this.IPaddress = new System.Windows.Forms.Label();
            this.btnServerMode = new System.Windows.Forms.Button();
            this.tmrmytorpedo = new System.Windows.Forms.Timer(this.components);
            this.tmrmygraphic = new System.Windows.Forms.Timer(this.components);
            this.tmrretry = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Main.SuspendLayout();
            this.endPanel.SuspendLayout();
            this.Setpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imghit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmiss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombsight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyfield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship12_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship12_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship12_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship13_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship13_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.Control;
            this.Main.Controls.Add(this.endPanel);
            this.Main.Controls.Add(this.Setpanel);
            this.Main.Controls.Add(this.richTextBox1);
            this.Main.Controls.Add(this.question);
            this.Main.Controls.Add(this.panel1);
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1924, 878);
            this.Main.TabIndex = 1;
            // 
            // endPanel
            // 
            this.endPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.endPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.endPanel.Controls.Add(this.btnexit);
            this.endPanel.Controls.Add(this.btnretry);
            this.endPanel.Controls.Add(this.labelresult);
            this.endPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.endPanel.Location = new System.Drawing.Point(12, 711);
            this.endPanel.Name = "endPanel";
            this.endPanel.Size = new System.Drawing.Size(1300, 650);
            this.endPanel.TabIndex = 52;
            this.endPanel.Visible = false;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexit.Location = new System.Drawing.Point(692, 373);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(200, 70);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "끝내기";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnretry
            // 
            this.btnretry.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnretry.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnretry.Location = new System.Drawing.Point(358, 373);
            this.btnretry.Name = "btnretry";
            this.btnretry.Size = new System.Drawing.Size(200, 70);
            this.btnretry.TabIndex = 1;
            this.btnretry.Text = "다시?";
            this.btnretry.UseVisualStyleBackColor = true;
            this.btnretry.Click += new System.EventHandler(this.retry_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelresult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelresult.Location = new System.Drawing.Point(390, 97);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(400, 128);
            this.labelresult.TabIndex = 0;
            this.labelresult.Text = "you win";
            // 
            // Setpanel
            // 
            this.Setpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Setpanel.Controls.Add(this.boom);
            this.Setpanel.Controls.Add(this.richTextBox2);
            this.Setpanel.Controls.Add(this.imghit);
            this.Setpanel.Controls.Add(this.imgmiss);
            this.Setpanel.Controls.Add(this.CrossHorizontal);
            this.Setpanel.Controls.Add(this.bombsight);
            this.Setpanel.Controls.Add(this.CrossVertical);
            this.Setpanel.Controls.Add(this.enemyfield);
            this.Setpanel.Controls.Add(this.arrow);
            this.Setpanel.Controls.Add(this.btnbomb);
            this.Setpanel.Controls.Add(this.btntorpedo);
            this.Setpanel.Controls.Add(this.shadow11);
            this.Setpanel.Controls.Add(this.shadow12);
            this.Setpanel.Controls.Add(this.shadow13);
            this.Setpanel.Controls.Add(this.shadow14);
            this.Setpanel.Controls.Add(this.labelready);
            this.Setpanel.Controls.Add(this.ship11_4);
            this.Setpanel.Controls.Add(this.ship11_3);
            this.Setpanel.Controls.Add(this.ship11_2);
            this.Setpanel.Controls.Add(this.ship11_1);
            this.Setpanel.Controls.Add(this.ship12_3);
            this.Setpanel.Controls.Add(this.ship12_2);
            this.Setpanel.Controls.Add(this.ship12_1);
            this.Setpanel.Controls.Add(this.ship13_2);
            this.Setpanel.Controls.Add(this.ship13_1);
            this.Setpanel.Controls.Add(this.ship14);
            this.Setpanel.Controls.Add(this.btnReset);
            this.Setpanel.Controls.Add(this.myfield);
            this.Setpanel.Controls.Add(this.btnReady);
            this.Setpanel.Location = new System.Drawing.Point(432, 29);
            this.Setpanel.Name = "Setpanel";
            this.Setpanel.Size = new System.Drawing.Size(1202, 846);
            this.Setpanel.TabIndex = 13;
            // 
            // boom
            // 
            this.boom.Image = global::Termproject.Properties.Resources.Boom;
            this.boom.Location = new System.Drawing.Point(1261, 179);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(50, 50);
            this.boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boom.TabIndex = 55;
            this.boom.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(497, 656);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(282, 266);
            this.richTextBox2.TabIndex = 56;
            this.richTextBox2.Text = "";
            // 
            // imghit
            // 
            this.imghit.Image = global::Termproject.Properties.Resources.Che;
            this.imghit.Location = new System.Drawing.Point(1250, 86);
            this.imghit.Name = "imghit";
            this.imghit.Size = new System.Drawing.Size(50, 50);
            this.imghit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imghit.TabIndex = 57;
            this.imghit.TabStop = false;
            // 
            // imgmiss
            // 
            this.imgmiss.Image = global::Termproject.Properties.Resources.Ok;
            this.imgmiss.Location = new System.Drawing.Point(1247, 30);
            this.imgmiss.Name = "imgmiss";
            this.imgmiss.Size = new System.Drawing.Size(50, 50);
            this.imgmiss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgmiss.TabIndex = 58;
            this.imgmiss.TabStop = false;
            // 
            // CrossHorizontal
            // 
            this.CrossHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CrossHorizontal.Enabled = false;
            this.CrossHorizontal.FlatAppearance.BorderSize = 0;
            this.CrossHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrossHorizontal.ForeColor = System.Drawing.Color.Transparent;
            this.CrossHorizontal.Location = new System.Drawing.Point(650, 275);
            this.CrossHorizontal.Name = "CrossHorizontal";
            this.CrossHorizontal.Size = new System.Drawing.Size(500, 50);
            this.CrossHorizontal.TabIndex = 47;
            this.CrossHorizontal.UseVisualStyleBackColor = false;
            this.CrossHorizontal.Visible = false;
            // 
            // bombsight
            // 
            this.bombsight.BackColor = System.Drawing.Color.Transparent;
            this.bombsight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bombsight.Enabled = false;
            this.bombsight.Image = global::Termproject.Properties.Resources.bs;
            this.bombsight.Location = new System.Drawing.Point(650, 403);
            this.bombsight.Name = "bombsight";
            this.bombsight.Size = new System.Drawing.Size(150, 150);
            this.bombsight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bombsight.TabIndex = 45;
            this.bombsight.TabStop = false;
            this.bombsight.Visible = false;
            // 
            // CrossVertical
            // 
            this.CrossVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CrossVertical.Enabled = false;
            this.CrossVertical.FlatAppearance.BorderSize = 0;
            this.CrossVertical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrossVertical.ForeColor = System.Drawing.Color.Transparent;
            this.CrossVertical.Location = new System.Drawing.Point(875, 50);
            this.CrossVertical.Name = "CrossVertical";
            this.CrossVertical.Size = new System.Drawing.Size(50, 500);
            this.CrossVertical.TabIndex = 53;
            this.CrossVertical.UseVisualStyleBackColor = false;
            this.CrossVertical.Visible = false;
            // 
            // enemyfield
            // 
            this.enemyfield.BackColor = System.Drawing.Color.Transparent;
            this.enemyfield.Image = ((System.Drawing.Image)(resources.GetObject("enemyfield.Image")));
            this.enemyfield.Location = new System.Drawing.Point(1247, 403);
            this.enemyfield.Name = "enemyfield";
            this.enemyfield.Size = new System.Drawing.Size(500, 500);
            this.enemyfield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyfield.TabIndex = 52;
            this.enemyfield.TabStop = false;
            this.enemyfield.Click += new System.EventHandler(this.enemyfield_Click);
            this.enemyfield.MouseLeave += new System.EventHandler(this.enemyfield_MouseLeave);
            this.enemyfield.MouseMove += new System.Windows.Forms.MouseEventHandler(this.enemyfield_MouseMove);
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Transparent;
            this.arrow.Image = global::Termproject.Properties.Resources.flagright;
            this.arrow.Location = new System.Drawing.Point(1250, 300);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(88, 252);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow.TabIndex = 51;
            this.arrow.TabStop = false;
            // 
            // btnbomb
            // 
            this.btnbomb.ForeColor = System.Drawing.Color.Black;
            this.btnbomb.Location = new System.Drawing.Point(1388, 419);
            this.btnbomb.Name = "btnbomb";
            this.btnbomb.Size = new System.Drawing.Size(100, 50);
            this.btnbomb.TabIndex = 44;
            this.btnbomb.Text = "비격진천뢰";
            this.btnbomb.UseVisualStyleBackColor = true;
            this.btnbomb.Click += new System.EventHandler(this.btnbomb_Click);
            // 
            // btntorpedo
            // 
            this.btntorpedo.ForeColor = System.Drawing.Color.Black;
            this.btntorpedo.Location = new System.Drawing.Point(1261, 419);
            this.btntorpedo.Name = "btntorpedo";
            this.btntorpedo.Size = new System.Drawing.Size(100, 50);
            this.btntorpedo.TabIndex = 43;
            this.btntorpedo.Text = "장군전";
            this.btntorpedo.UseVisualStyleBackColor = true;
            this.btntorpedo.Click += new System.EventHandler(this.btntorpedo_Click);
            // 
            // shadow11
            // 
            this.shadow11.BackColor = System.Drawing.Color.Lime;
            this.shadow11.Enabled = false;
            this.shadow11.FlatAppearance.BorderSize = 0;
            this.shadow11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadow11.Location = new System.Drawing.Point(518, 587);
            this.shadow11.Name = "shadow11";
            this.shadow11.Size = new System.Drawing.Size(50, 50);
            this.shadow11.TabIndex = 31;
            this.shadow11.UseVisualStyleBackColor = false;
            this.shadow11.Visible = false;
            // 
            // shadow12
            // 
            this.shadow12.BackColor = System.Drawing.Color.Lime;
            this.shadow12.Enabled = false;
            this.shadow12.FlatAppearance.BorderSize = 0;
            this.shadow12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadow12.Location = new System.Drawing.Point(412, 587);
            this.shadow12.Name = "shadow12";
            this.shadow12.Size = new System.Drawing.Size(100, 50);
            this.shadow12.TabIndex = 30;
            this.shadow12.UseVisualStyleBackColor = false;
            this.shadow12.Visible = false;
            // 
            // shadow13
            // 
            this.shadow13.BackColor = System.Drawing.Color.Lime;
            this.shadow13.Enabled = false;
            this.shadow13.FlatAppearance.BorderSize = 0;
            this.shadow13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadow13.Location = new System.Drawing.Point(256, 587);
            this.shadow13.Name = "shadow13";
            this.shadow13.Size = new System.Drawing.Size(150, 50);
            this.shadow13.TabIndex = 29;
            this.shadow13.UseVisualStyleBackColor = false;
            this.shadow13.Visible = false;
            // 
            // shadow14
            // 
            this.shadow14.BackColor = System.Drawing.Color.Lime;
            this.shadow14.Enabled = false;
            this.shadow14.FlatAppearance.BorderSize = 0;
            this.shadow14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadow14.Location = new System.Drawing.Point(50, 587);
            this.shadow14.Name = "shadow14";
            this.shadow14.Size = new System.Drawing.Size(200, 50);
            this.shadow14.TabIndex = 28;
            this.shadow14.UseVisualStyleBackColor = false;
            this.shadow14.Visible = false;
            // 
            // labelready
            // 
            this.labelready.AutoSize = true;
            this.labelready.Location = new System.Drawing.Point(1038, 493);
            this.labelready.Name = "labelready";
            this.labelready.Size = new System.Drawing.Size(160, 15);
            this.labelready.TabIndex = 27;
            this.labelready.Text = "Not all Battleships are ready.";
            // 
            // ship11_4
            // 
            this.ship11_4.Image = global::Termproject.Properties.Resources.ship11;
            this.ship11_4.Location = new System.Drawing.Point(950, 350);
            this.ship11_4.Name = "ship11_4";
            this.ship11_4.Size = new System.Drawing.Size(50, 50);
            this.ship11_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship11_4.TabIndex = 12;
            this.ship11_4.TabStop = false;
            this.ship11_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship11_4_MouseDown);
            this.ship11_4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship11_4_MouseMove);
            this.ship11_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship11_4_MouseUp);
            // 
            // ship11_3
            // 
            this.ship11_3.Image = global::Termproject.Properties.Resources.ship11;
            this.ship11_3.Location = new System.Drawing.Point(850, 350);
            this.ship11_3.Name = "ship11_3";
            this.ship11_3.Size = new System.Drawing.Size(50, 50);
            this.ship11_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship11_3.TabIndex = 11;
            this.ship11_3.TabStop = false;
            this.ship11_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship11_3_MouseDown);
            this.ship11_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship11_3_MouseMove);
            this.ship11_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship11_3_MouseUp);
            // 
            // ship11_2
            // 
            this.ship11_2.Image = global::Termproject.Properties.Resources.ship11;
            this.ship11_2.Location = new System.Drawing.Point(750, 350);
            this.ship11_2.Name = "ship11_2";
            this.ship11_2.Size = new System.Drawing.Size(50, 50);
            this.ship11_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship11_2.TabIndex = 10;
            this.ship11_2.TabStop = false;
            this.ship11_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship11_2_MouseDown);
            this.ship11_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship11_2_MouseMove);
            this.ship11_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship11_2_MouseUp);
            // 
            // ship11_1
            // 
            this.ship11_1.Image = global::Termproject.Properties.Resources.ship11;
            this.ship11_1.Location = new System.Drawing.Point(650, 350);
            this.ship11_1.Name = "ship11_1";
            this.ship11_1.Size = new System.Drawing.Size(50, 50);
            this.ship11_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship11_1.TabIndex = 9;
            this.ship11_1.TabStop = false;
            this.ship11_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship11_1_MouseDown);
            this.ship11_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship11_1_MouseMove);
            this.ship11_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship11_1_MouseUp);
            // 
            // ship12_3
            // 
            this.ship12_3.Image = global::Termproject.Properties.Resources.ship12;
            this.ship12_3.Location = new System.Drawing.Point(950, 250);
            this.ship12_3.Name = "ship12_3";
            this.ship12_3.Size = new System.Drawing.Size(100, 50);
            this.ship12_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship12_3.TabIndex = 8;
            this.ship12_3.TabStop = false;
            this.ship12_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship12_3_MouseDown);
            this.ship12_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship12_3_MouseMove);
            this.ship12_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship12_3_MouseUp);
            // 
            // ship12_2
            // 
            this.ship12_2.Image = global::Termproject.Properties.Resources.ship12;
            this.ship12_2.Location = new System.Drawing.Point(800, 250);
            this.ship12_2.Name = "ship12_2";
            this.ship12_2.Size = new System.Drawing.Size(100, 50);
            this.ship12_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship12_2.TabIndex = 7;
            this.ship12_2.TabStop = false;
            this.ship12_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship12_2_MouseDown);
            this.ship12_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship12_2_MouseMove);
            this.ship12_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship12_2_MouseUp);
            // 
            // ship12_1
            // 
            this.ship12_1.Image = global::Termproject.Properties.Resources.ship12;
            this.ship12_1.Location = new System.Drawing.Point(650, 250);
            this.ship12_1.Name = "ship12_1";
            this.ship12_1.Size = new System.Drawing.Size(100, 50);
            this.ship12_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship12_1.TabIndex = 6;
            this.ship12_1.TabStop = false;
            this.ship12_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship12_1_MouseDown);
            this.ship12_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship12_1_MouseMove);
            this.ship12_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship12_1_MouseUp);
            // 
            // ship13_2
            // 
            this.ship13_2.Image = global::Termproject.Properties.Resources.ship13;
            this.ship13_2.Location = new System.Drawing.Point(850, 150);
            this.ship13_2.Name = "ship13_2";
            this.ship13_2.Size = new System.Drawing.Size(150, 50);
            this.ship13_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship13_2.TabIndex = 5;
            this.ship13_2.TabStop = false;
            this.ship13_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship13_2_MouseDown);
            this.ship13_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship13_2_MouseMove);
            this.ship13_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship13_2_MouseUp);
            // 
            // ship13_1
            // 
            this.ship13_1.Image = global::Termproject.Properties.Resources.ship13;
            this.ship13_1.Location = new System.Drawing.Point(650, 150);
            this.ship13_1.Name = "ship13_1";
            this.ship13_1.Size = new System.Drawing.Size(150, 50);
            this.ship13_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship13_1.TabIndex = 4;
            this.ship13_1.TabStop = false;
            this.ship13_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship13_1_MouseDown);
            this.ship13_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship13_1_MouseMove);
            this.ship13_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship13_1_MouseUp);
            // 
            // ship14
            // 
            this.ship14.BackColor = System.Drawing.Color.Transparent;
            this.ship14.Image = global::Termproject.Properties.Resources.ship14;
            this.ship14.Location = new System.Drawing.Point(650, 50);
            this.ship14.Name = "ship14";
            this.ship14.Size = new System.Drawing.Size(200, 50);
            this.ship14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship14.TabIndex = 3;
            this.ship14.TabStop = false;
            this.ship14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship14_MouseDown);
            this.ship14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship14_MouseMove);
            this.ship14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ship14_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(650, 450);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 100);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.reset_Click);
            // 
            // myfield
            // 
            this.myfield.BackColor = System.Drawing.Color.Transparent;
            this.myfield.Image = global::Termproject.Properties.Resources.pan;
            this.myfield.Location = new System.Drawing.Point(50, 50);
            this.myfield.Name = "myfield";
            this.myfield.Size = new System.Drawing.Size(500, 500);
            this.myfield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myfield.TabIndex = 15;
            this.myfield.TabStop = false;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(850, 450);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(150, 100);
            this.btnReady.TabIndex = 0;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(501, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(201, 360);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.Transparent;
            this.question.Image = global::Termproject.Properties.Resources.question;
            this.question.Location = new System.Drawing.Point(235, 3);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(79, 77);
            this.question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.question.TabIndex = 9;
            this.question.TabStop = false;
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJoinGame);
            this.panel1.Controls.Add(this.labelipadress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InsertIpTextBox);
            this.panel1.Controls.Add(this.IPaddress);
            this.panel1.Controls.Add(this.btnServerMode);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 204);
            this.panel1.TabIndex = 8;
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Enabled = false;
            this.btnJoinGame.Location = new System.Drawing.Point(151, 145);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(128, 40);
            this.btnJoinGame.TabIndex = 6;
            this.btnJoinGame.Text = "게임 참가";
            this.btnJoinGame.UseVisualStyleBackColor = true;
            this.btnJoinGame.Click += new System.EventHandler(this.ClientConnect_Click);
            // 
            // labelipadress
            // 
            this.labelipadress.AutoSize = true;
            this.labelipadress.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelipadress.Location = new System.Drawing.Point(157, 47);
            this.labelipadress.Name = "labelipadress";
            this.labelipadress.Size = new System.Drawing.Size(0, 30);
            this.labelipadress.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "참가 IP 주소";
            // 
            // InsertIpTextBox
            // 
            this.InsertIpTextBox.Location = new System.Drawing.Point(151, 96);
            this.InsertIpTextBox.Name = "InsertIpTextBox";
            this.InsertIpTextBox.Size = new System.Drawing.Size(145, 23);
            this.InsertIpTextBox.TabIndex = 3;
            this.InsertIpTextBox.TextChanged += new System.EventHandler(this.InsertIpTextBox_TextChanged);
            // 
            // IPaddress
            // 
            this.IPaddress.AutoSize = true;
            this.IPaddress.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPaddress.Location = new System.Drawing.Point(16, 47);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(141, 30);
            this.IPaddress.TabIndex = 0;
            this.IPaddress.Text = "나의 IP 주소 :";
            // 
            // btnServerMode
            // 
            this.btnServerMode.Location = new System.Drawing.Point(23, 145);
            this.btnServerMode.Name = "btnServerMode";
            this.btnServerMode.Size = new System.Drawing.Size(128, 40);
            this.btnServerMode.TabIndex = 5;
            this.btnServerMode.Text = "게임 참가 모드";
            this.btnServerMode.UseVisualStyleBackColor = true;
            this.btnServerMode.Click += new System.EventHandler(this.ServerOpen_Click);
            // 
            // tmrmytorpedo
            // 
            this.tmrmytorpedo.Interval = 300;
            this.tmrmytorpedo.Tick += new System.EventHandler(this.tmrmytorpedo_Tick);
            // 
            // tmrmygraphic
            // 
            this.tmrmygraphic.Enabled = true;
            this.tmrmygraphic.Interval = 300;
            this.tmrmygraphic.Tick += new System.EventHandler(this.tmrmygraphic_Tick);
            // 
            // tmrretry
            // 
            this.tmrretry.Tick += new System.EventHandler(this.tmrretry_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Main.ResumeLayout(false);
            this.endPanel.ResumeLayout(false);
            this.endPanel.PerformLayout();
            this.Setpanel.ResumeLayout(false);
            this.Setpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imghit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmiss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombsight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyfield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship11_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship12_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship12_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship12_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship13_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship13_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsertIpTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IPaddress;
        private System.Windows.Forms.Button btnServerMode;
        private System.Windows.Forms.PictureBox question;
        private System.Windows.Forms.Label labelipadress;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel Setpanel;
        private System.Windows.Forms.Button shadow11;
        private System.Windows.Forms.Button shadow12;
        private System.Windows.Forms.Button shadow13;
        private System.Windows.Forms.Button shadow14;
        private System.Windows.Forms.Label labelready;
        private System.Windows.Forms.PictureBox ship11_4;
        private System.Windows.Forms.PictureBox ship11_3;
        private System.Windows.Forms.PictureBox ship11_2;
        private System.Windows.Forms.PictureBox ship11_1;
        private System.Windows.Forms.PictureBox ship12_3;
        private System.Windows.Forms.PictureBox ship12_2;
        private System.Windows.Forms.PictureBox ship12_1;
        private System.Windows.Forms.PictureBox ship13_2;
        private System.Windows.Forms.PictureBox ship13_1;
        private System.Windows.Forms.PictureBox ship14;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox myfield;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnbomb;
        private System.Windows.Forms.Button btntorpedo;
        private System.Windows.Forms.PictureBox bombsight;
        private System.Windows.Forms.Panel endPanel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnretry;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button CrossVertical;
        private System.Windows.Forms.PictureBox enemyfield;
        private System.Windows.Forms.Button CrossHorizontal;
        private System.Windows.Forms.PictureBox arrow;
        private System.Windows.Forms.PictureBox boom;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer tmrmytorpedo;
        private System.Windows.Forms.Timer tmrmygraphic;
        private System.Windows.Forms.PictureBox imgmiss;
        private System.Windows.Forms.PictureBox imghit;
        private System.Windows.Forms.Timer tmrretry;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
