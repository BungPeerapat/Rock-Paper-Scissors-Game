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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.EXIT2 = new System.Windows.Forms.Button();
            this.BACKGROUNDGAMESTART = new System.Windows.Forms.PictureBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.AT1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PictureMain = new System.Windows.Forms.PictureBox();
            this.AT2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.paper = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.Scissors = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.Rock = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.CB = new Rock_Paper_Scissors_Game.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BACKGROUNDGAMESTART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB)).BeginInit();
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
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AT1.DefaultAnimation = animation3;
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
            // AT2
            // 
            this.AT2.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.AT2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(50);
            animation4.RotateCoeff = 1F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.AT2.DefaultAnimation = animation4;
            // 
            // paper
            // 
            this.AT1.SetDecoration(this.paper, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.paper, BunifuAnimatorNS.DecorationType.None);
            this.paper.Image = ((System.Drawing.Image)(resources.GetObject("paper.Image")));
            this.paper.Location = new System.Drawing.Point(643, 278);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(182, 177);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.paper.TabIndex = 7;
            this.paper.TabStop = false;
            // 
            // Scissors
            // 
            this.AT1.SetDecoration(this.Scissors, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.Scissors, BunifuAnimatorNS.DecorationType.None);
            this.Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Scissors.Image")));
            this.Scissors.Location = new System.Drawing.Point(349, 278);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(182, 177);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Scissors.TabIndex = 6;
            this.Scissors.TabStop = false;
            // 
            // Rock
            // 
            this.AT1.SetDecoration(this.Rock, BunifuAnimatorNS.DecorationType.None);
            this.AT2.SetDecoration(this.Rock, BunifuAnimatorNS.DecorationType.None);
            this.Rock.Image = ((System.Drawing.Image)(resources.GetObject("Rock.Image")));
            this.Rock.Location = new System.Drawing.Point(22, 278);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(182, 177);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Rock.TabIndex = 5;
            this.Rock.TabStop = false;
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
            // Game
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 572);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
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
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB)).EndInit();
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
        private CircularPictureBox Rock;
        private CircularPictureBox Scissors;
        private CircularPictureBox paper;
    }
}