namespace Rock_Paper_Scissors_Game
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.EXIT2 = new System.Windows.Forms.Button();
            this.BACKGROUNDGAMESTART = new System.Windows.Forms.PictureBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.AT1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PictureMain = new System.Windows.Forms.PictureBox();
            this.PLAYERNAME = new System.Windows.Forms.Label();
            this.BOTNAME = new System.Windows.Forms.Label();
            this.CountDownCC = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.CB = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.PlayerC = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.BOTC = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.paper = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.Scissors = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.Rock = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.circularPictureBox1 = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.circularPictureBox2 = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.AT2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AT3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.POINTPLAYER = new System.Windows.Forms.Label();
            this.POINTBOT = new System.Windows.Forms.Label();
            this.POINTNUMBERPLAYER = new System.Windows.Forms.Label();
            this.POINTNUMBERBOT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BACKGROUNDGAMESTART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // EXIT2
            // 
            this.EXIT2.BackColor = System.Drawing.Color.PapayaWhip;
            this.EXIT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AT3.SetDecoration(this.EXIT2, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.EXIT2, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.EXIT2, BunifuAnimatorNS.DecorationType.None);
            this.EXIT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.EXIT2.ForeColor = System.Drawing.Color.Firebrick;
            this.EXIT2.Location = new System.Drawing.Point(671, 587);
            this.EXIT2.Name = "EXIT2";
            this.EXIT2.Size = new System.Drawing.Size(157, 56);
            this.EXIT2.TabIndex = 1;
            this.EXIT2.Text = "EXIT";
            this.EXIT2.UseVisualStyleBackColor = false;
            // 
            // BACKGROUNDGAMESTART
            // 
            this.BACKGROUNDGAMESTART.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AT3.SetDecoration(this.BACKGROUNDGAMESTART, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.BACKGROUNDGAMESTART, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.BACKGROUNDGAMESTART, BunifuAnimatorNS.DecorationType.None);
            this.BACKGROUNDGAMESTART.Image = ((System.Drawing.Image)(resources.GetObject("BACKGROUNDGAMESTART.Image")));
            this.BACKGROUNDGAMESTART.Location = new System.Drawing.Point(2, -11);
            this.BACKGROUNDGAMESTART.Name = "BACKGROUNDGAMESTART";
            this.BACKGROUNDGAMESTART.Size = new System.Drawing.Size(851, 585);
            this.BACKGROUNDGAMESTART.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BACKGROUNDGAMESTART.TabIndex = 2;
            this.BACKGROUNDGAMESTART.TabStop = false;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.PapayaWhip;
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AT3.SetDecoration(this.EXIT, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.EXIT, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.EXIT, BunifuAnimatorNS.DecorationType.None);
            this.EXIT.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.Firebrick;
            this.EXIT.Location = new System.Drawing.Point(612, 505);
            this.EXIT.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(223, 57);
            this.EXIT.TabIndex = 3;
            this.EXIT.Text = "EXIT GAME";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click_1);
            // 
            // AT1
            // 
            this.AT1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.AT1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.AT1.DefaultAnimation = animation4;
            // 
            // PictureMain
            // 
            this.PictureMain.BackColor = System.Drawing.Color.Transparent;
            this.PictureMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AT3.SetDecoration(this.PictureMain, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.PictureMain, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.PictureMain, BunifuAnimatorNS.DecorationType.None);
            this.PictureMain.Image = ((System.Drawing.Image)(resources.GetObject("PictureMain.Image")));
            this.PictureMain.Location = new System.Drawing.Point(210, 92);
            this.PictureMain.Name = "PictureMain";
            this.PictureMain.Size = new System.Drawing.Size(445, 363);
            this.PictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMain.TabIndex = 4;
            this.PictureMain.TabStop = false;
            this.PictureMain.Visible = false;
            this.PictureMain.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PLAYERNAME
            // 
            this.PLAYERNAME.AutoSize = true;
            this.AT3.SetDecoration(this.PLAYERNAME, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.PLAYERNAME, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.PLAYERNAME, BunifuAnimatorNS.DecorationType.None);
            this.PLAYERNAME.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.PLAYERNAME.ForeColor = System.Drawing.Color.Navy;
            this.PLAYERNAME.Location = new System.Drawing.Point(12, 125);
            this.PLAYERNAME.Name = "PLAYERNAME";
            this.PLAYERNAME.Size = new System.Drawing.Size(138, 48);
            this.PLAYERNAME.TabIndex = 8;
            this.PLAYERNAME.Text = "PLAYER";
            // 
            // BOTNAME
            // 
            this.BOTNAME.AutoSize = true;
            this.AT3.SetDecoration(this.BOTNAME, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.BOTNAME, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.BOTNAME, BunifuAnimatorNS.DecorationType.None);
            this.BOTNAME.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.BOTNAME.ForeColor = System.Drawing.Color.Maroon;
            this.BOTNAME.Location = new System.Drawing.Point(721, 125);
            this.BOTNAME.Name = "BOTNAME";
            this.BOTNAME.Size = new System.Drawing.Size(85, 48);
            this.BOTNAME.TabIndex = 8;
            this.BOTNAME.Text = "BOT";
            // 
            // CountDownCC
            // 
            this.CountDownCC.BackColor = System.Drawing.Color.Transparent;
            this.AT3.SetDecoration(this.CountDownCC, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.CountDownCC, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.CountDownCC, BunifuAnimatorNS.DecorationType.None);
            this.CountDownCC.Enabled = false;
            this.CountDownCC.Location = new System.Drawing.Point(298, 258);
            this.CountDownCC.Name = "CountDownCC";
            this.CountDownCC.Size = new System.Drawing.Size(271, 221);
            this.CountDownCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CountDownCC.TabIndex = 9;
            this.CountDownCC.TabStop = false;
            this.CountDownCC.Visible = false;
            this.CountDownCC.Click += new System.EventHandler(this.CountDownCC_Click_1);
            // 
            // CB
            // 
            this.CB.BackColor = System.Drawing.Color.Transparent;
            this.CB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AT3.SetDecoration(this.CB, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.CB, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.CB, BunifuAnimatorNS.DecorationType.None);
            this.CB.Image = ((System.Drawing.Image)(resources.GetObject("CB.Image")));
            this.CB.Location = new System.Drawing.Point(195, 45);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(493, 434);
            this.CB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CB.TabIndex = 0;
            this.CB.TabStop = false;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // PlayerC
            // 
            this.PlayerC.BackColor = System.Drawing.Color.Transparent;
            this.AT3.SetDecoration(this.PlayerC, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.PlayerC, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.PlayerC, BunifuAnimatorNS.DecorationType.None);
            this.PlayerC.Image = ((System.Drawing.Image)(resources.GetObject("PlayerC.Image")));
            this.PlayerC.Location = new System.Drawing.Point(162, 63);
            this.PlayerC.Name = "PlayerC";
            this.PlayerC.Size = new System.Drawing.Size(179, 170);
            this.PlayerC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerC.TabIndex = 7;
            this.PlayerC.TabStop = false;
            // 
            // BOTC
            // 
            this.BOTC.BackColor = System.Drawing.Color.Transparent;
            this.AT3.SetDecoration(this.BOTC, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.BOTC, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.BOTC, BunifuAnimatorNS.DecorationType.None);
            this.BOTC.Image = ((System.Drawing.Image)(resources.GetObject("BOTC.Image")));
            this.BOTC.Location = new System.Drawing.Point(509, 63);
            this.BOTC.Name = "BOTC";
            this.BOTC.Size = new System.Drawing.Size(182, 177);
            this.BOTC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BOTC.TabIndex = 7;
            this.BOTC.TabStop = false;
            // 
            // paper
            // 
            this.AT3.SetDecoration(this.paper, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.paper, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.paper, BunifuAnimatorNS.DecorationType.None);
            this.paper.Image = ((System.Drawing.Image)(resources.GetObject("paper.Image")));
            this.paper.Location = new System.Drawing.Point(643, 278);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(182, 177);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.paper.TabIndex = 7;
            this.paper.TabStop = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // Scissors
            // 
            this.AT3.SetDecoration(this.Scissors, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.Scissors, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.Scissors, BunifuAnimatorNS.DecorationType.None);
            this.Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Scissors.Image")));
            this.Scissors.Location = new System.Drawing.Point(349, 278);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(182, 177);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Scissors.TabIndex = 6;
            this.Scissors.TabStop = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Rock
            // 
            this.AT3.SetDecoration(this.Rock, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.Rock, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.Rock, BunifuAnimatorNS.DecorationType.None);
            this.Rock.Image = ((System.Drawing.Image)(resources.GetObject("Rock.Image")));
            this.Rock.Location = new System.Drawing.Point(42, 278);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(182, 177);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Rock.TabIndex = 5;
            this.Rock.TabStop = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // circularPictureBox1
            // 
            this.AT3.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox1.Location = new System.Drawing.Point(210, 56);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(182, 177);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox1.TabIndex = 7;
            this.circularPictureBox1.TabStop = false;
            // 
            // circularPictureBox2
            // 
            this.AT3.SetDecoration(this.circularPictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.circularPictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.circularPictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox2.Location = new System.Drawing.Point(506, 56);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(182, 177);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox2.TabIndex = 7;
            this.circularPictureBox2.TabStop = false;
            // 
            // AT2
            // 
            this.AT2.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.AT2.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(50);
            animation5.RotateCoeff = 1F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.AT2.DefaultAnimation = animation5;
            // 
            // AT3
            // 
            this.AT3.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.AT3.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(50);
            animation6.RotateCoeff = 1F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.AT3.DefaultAnimation = animation6;
            // 
            // POINTPLAYER
            // 
            this.POINTPLAYER.AutoSize = true;
            this.POINTPLAYER.BackColor = System.Drawing.Color.Transparent;
            this.AT3.SetDecoration(this.POINTPLAYER, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.POINTPLAYER, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.POINTPLAYER, BunifuAnimatorNS.DecorationType.None);
            this.POINTPLAYER.Font = new System.Drawing.Font("Franxurter Totally Fat", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POINTPLAYER.ForeColor = System.Drawing.Color.MidnightBlue;
            this.POINTPLAYER.Location = new System.Drawing.Point(153, 11);
            this.POINTPLAYER.Name = "POINTPLAYER";
            this.POINTPLAYER.Size = new System.Drawing.Size(176, 49);
            this.POINTPLAYER.TabIndex = 10;
            this.POINTPLAYER.Text = "POINT : ";
            // 
            // POINTBOT
            // 
            this.POINTBOT.AutoSize = true;
            this.POINTBOT.BackColor = System.Drawing.Color.Transparent;
            this.AT3.SetDecoration(this.POINTBOT, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.POINTBOT, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.POINTBOT, BunifuAnimatorNS.DecorationType.None);
            this.POINTBOT.Font = new System.Drawing.Font("Franxurter Totally Fat", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POINTBOT.ForeColor = System.Drawing.Color.Maroon;
            this.POINTBOT.Location = new System.Drawing.Point(500, 11);
            this.POINTBOT.Name = "POINTBOT";
            this.POINTBOT.Size = new System.Drawing.Size(176, 49);
            this.POINTBOT.TabIndex = 10;
            this.POINTBOT.Text = "POINT : ";
            // 
            // POINTNUMBERPLAYER
            // 
            this.POINTNUMBERPLAYER.AutoSize = true;
            this.POINTNUMBERPLAYER.BackColor = System.Drawing.Color.Transparent;
            this.AT3.SetDecoration(this.POINTNUMBERPLAYER, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.POINTNUMBERPLAYER, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.POINTNUMBERPLAYER, BunifuAnimatorNS.DecorationType.None);
            this.POINTNUMBERPLAYER.Font = new System.Drawing.Font("Franxurter Totally Fat", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POINTNUMBERPLAYER.ForeColor = System.Drawing.Color.MidnightBlue;
            this.POINTNUMBERPLAYER.Location = new System.Drawing.Point(303, 11);
            this.POINTNUMBERPLAYER.Name = "POINTNUMBERPLAYER";
            this.POINTNUMBERPLAYER.Size = new System.Drawing.Size(47, 49);
            this.POINTNUMBERPLAYER.TabIndex = 10;
            this.POINTNUMBERPLAYER.Text = "0";
            // 
            // POINTNUMBERBOT
            // 
            this.POINTNUMBERBOT.AutoSize = true;
            this.POINTNUMBERBOT.BackColor = System.Drawing.Color.Transparent;
            this.AT3.SetDecoration(this.POINTNUMBERBOT, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.POINTNUMBERBOT, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this.POINTNUMBERBOT, BunifuAnimatorNS.DecorationType.None);
            this.POINTNUMBERBOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POINTNUMBERBOT.Font = new System.Drawing.Font("Franxurter Totally Fat", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POINTNUMBERBOT.ForeColor = System.Drawing.Color.Maroon;
            this.POINTNUMBERBOT.Location = new System.Drawing.Point(653, 11);
            this.POINTNUMBERBOT.Name = "POINTNUMBERBOT";
            this.POINTNUMBERBOT.Size = new System.Drawing.Size(47, 49);
            this.POINTNUMBERBOT.TabIndex = 10;
            this.POINTNUMBERBOT.Text = "0";
            // 
            // Game
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 572);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.POINTNUMBERPLAYER);
            this.Controls.Add(this.POINTNUMBERBOT);
            this.Controls.Add(this.POINTBOT);
            this.Controls.Add(this.POINTPLAYER);
            this.Controls.Add(this.CountDownCC);
            this.Controls.Add(this.BOTNAME);
            this.Controls.Add(this.PLAYERNAME);
            this.Controls.Add(this.PlayerC);
            this.Controls.Add(this.BOTC);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.EXIT2);
            this.Controls.Add(this.PictureMain);
            this.Controls.Add(this.BACKGROUNDGAMESTART);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.circularPictureBox2);
            this.AT3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let Started!";
            ((System.ComponentModel.ISupportInitialize)(this.BACKGROUNDGAMESTART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox CB;
        private System.Windows.Forms.Button EXIT2;
        private System.Windows.Forms.PictureBox BACKGROUNDGAMESTART;
        private System.Windows.Forms.Button EXIT;
        private object RPSGAMECC;
        private BunifuAnimatorNS.BunifuTransition AT1;
        public System.Windows.Forms.PictureBox PictureMain;
        private BunifuAnimatorNS.BunifuTransition AT2;
        private CircularPictureBox Rock;
        private CircularPictureBox Scissors;
        private CircularPictureBox paper;
        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox2;
        public CircularPictureBox PlayerC;
        public CircularPictureBox BOTC;
        private System.Windows.Forms.Label PLAYERNAME;
        private System.Windows.Forms.Label BOTNAME;
        private CircularPictureBox CountDownCC;
        private BunifuAnimatorNS.BunifuTransition AT3;
        private System.Windows.Forms.Label POINTPLAYER;
        private System.Windows.Forms.Label POINTBOT;
        private System.Windows.Forms.Label POINTNUMBERPLAYER;
        private System.Windows.Forms.Label POINTNUMBERBOT;
    }
}