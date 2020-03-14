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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.EXIT2 = new System.Windows.Forms.Button();
            this.BACKGROUNDGAMESTART = new System.Windows.Forms.PictureBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.AT1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PictureMain = new System.Windows.Forms.PictureBox();
            this.CB = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.AT2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.circularPictureBox1 = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.circularPictureBox2 = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.circularPictureBox3 = new Rock_Paper_Scissors_Game.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BACKGROUNDGAMESTART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // EXIT2
            // 
            this.EXIT2.BackColor = System.Drawing.Color.PapayaWhip;
            this.EXIT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AT1.SetDecoration(this.EXIT2, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.EXIT2, BunifuAnimatorNS.DecorationType.None);
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
            this.AT1.SetDecoration(this.BACKGROUNDGAMESTART, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.BACKGROUNDGAMESTART, BunifuAnimatorNS.DecorationType.None);
            this.BACKGROUNDGAMESTART.Image = ((System.Drawing.Image)(resources.GetObject("BACKGROUNDGAMESTART.Image")));
            this.BACKGROUNDGAMESTART.Location = new System.Drawing.Point(-3, -4);
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
            this.AT1.SetDecoration(this.EXIT, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.EXIT, BunifuAnimatorNS.DecorationType.None);
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
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AT1.DefaultAnimation = animation1;
            // 
            // PictureMain
            // 
            this.PictureMain.BackColor = System.Drawing.Color.Transparent;
            this.PictureMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AT1.SetDecoration(this.PictureMain, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.PictureMain, BunifuAnimatorNS.DecorationType.None);
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
            // CB
            // 
            this.CB.BackColor = System.Drawing.Color.Transparent;
            this.CB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AT1.SetDecoration(this.CB, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.CB, BunifuAnimatorNS.DecorationType.None);
            this.CB.Image = ((System.Drawing.Image)(resources.GetObject("CB.Image")));
            this.CB.Location = new System.Drawing.Point(195, 45);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(493, 434);
            this.CB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CB.TabIndex = 0;
            this.CB.TabStop = false;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // AT2
            // 
            this.AT2.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.AT2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.AT2.DefaultAnimation = animation2;
            // 
            // circularPictureBox1
            // 
            this.AT1.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox1.Location = new System.Drawing.Point(22, 278);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(182, 177);
            this.circularPictureBox1.TabIndex = 5;
            this.circularPictureBox1.TabStop = false;
            // 
            // circularPictureBox2
            // 
            this.AT1.SetDecoration(this.circularPictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.circularPictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox2.Location = new System.Drawing.Point(347, 278);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(182, 177);
            this.circularPictureBox2.TabIndex = 6;
            this.circularPictureBox2.TabStop = false;
            // 
            // circularPictureBox3
            // 
            this.AT1.SetDecoration(this.circularPictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.circularPictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox3.Location = new System.Drawing.Point(652, 278);
            this.circularPictureBox3.Name = "circularPictureBox3";
            this.circularPictureBox3.Size = new System.Drawing.Size(182, 177);
            this.circularPictureBox3.TabIndex = 7;
            this.circularPictureBox3.TabStop = false;
            // 
            // Game
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 572);
            this.Controls.Add(this.circularPictureBox3);
            this.Controls.Add(this.circularPictureBox2);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.EXIT2);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.PictureMain);
            this.Controls.Add(this.BACKGROUNDGAMESTART);
            this.AT2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AT1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let Started!";
            ((System.ComponentModel.ISupportInitialize)(this.BACKGROUNDGAMESTART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).EndInit();
            this.ResumeLayout(false);

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
        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox2;
        private CircularPictureBox circularPictureBox3;
    }
}