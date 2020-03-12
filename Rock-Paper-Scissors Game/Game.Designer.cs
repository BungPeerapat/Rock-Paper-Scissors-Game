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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.CB = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.EXIT2 = new System.Windows.Forms.Button();
            this.BACKGROUNDGAMESTART = new System.Windows.Forms.PictureBox();
            this.EXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACKGROUNDGAMESTART)).BeginInit();
            this.SuspendLayout();
            // 
            // CB
            // 
            this.CB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB.Image = ((System.Drawing.Image)(resources.GetObject("CB.Image")));
            this.CB.Location = new System.Drawing.Point(242, 117);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(326, 302);
            this.CB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CB.TabIndex = 0;
            this.CB.TabStop = false;
            // 
            // EXIT2
            // 
            this.EXIT2.BackColor = System.Drawing.Color.PapayaWhip;
            this.EXIT2.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.BACKGROUNDGAMESTART.Image = ((System.Drawing.Image)(resources.GetObject("BACKGROUNDGAMESTART.Image")));
            this.BACKGROUNDGAMESTART.Location = new System.Drawing.Point(-2, -10);
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
            // Game
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 572);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.EXIT2);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.BACKGROUNDGAMESTART);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let Started!";
            ((System.ComponentModel.ISupportInitialize)(this.CB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACKGROUNDGAMESTART)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularPictureBox CB;
        private System.Windows.Forms.Button EXIT2;
        private System.Windows.Forms.PictureBox BACKGROUNDGAMESTART;
        private System.Windows.Forms.Button EXIT;
    }
}