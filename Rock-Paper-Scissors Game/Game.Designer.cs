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
            this.BGGAMESTART = new System.Windows.Forms.PictureBox();
            this.CB1 = new Rock_Paper_Scissors_Game.CircularPictureBox();
            this.EXITBUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BGGAMESTART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB1)).BeginInit();
            this.SuspendLayout();
            // 
            // BGGAMESTART
            // 
            this.BGGAMESTART.Image = ((System.Drawing.Image)(resources.GetObject("BGGAMESTART.Image")));
            this.BGGAMESTART.Location = new System.Drawing.Point(0, -4);
            this.BGGAMESTART.Name = "BGGAMESTART";
            this.BGGAMESTART.Size = new System.Drawing.Size(842, 674);
            this.BGGAMESTART.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGGAMESTART.TabIndex = 0;
            this.BGGAMESTART.TabStop = false;
            this.BGGAMESTART.Click += new System.EventHandler(this.BGGAMESTART_Click);
            // 
            // CB1
            // 
            this.CB1.Image = ((System.Drawing.Image)(resources.GetObject("CB1.Image")));
            this.CB1.Location = new System.Drawing.Point(195, 94);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(491, 374);
            this.CB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CB1.TabIndex = 1;
            this.CB1.TabStop = false;
            this.CB1.Click += new System.EventHandler(this.CB1_Click);
            // 
            // EXITBUTTON
            // 
            this.EXITBUTTON.BackColor = System.Drawing.Color.PapayaWhip;
            this.EXITBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXITBUTTON.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXITBUTTON.ForeColor = System.Drawing.Color.Firebrick;
            this.EXITBUTTON.Location = new System.Drawing.Point(606, 588);
            this.EXITBUTTON.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EXITBUTTON.Name = "EXITBUTTON";
            this.EXITBUTTON.Size = new System.Drawing.Size(223, 57);
            this.EXITBUTTON.TabIndex = 2;
            this.EXITBUTTON.Text = "EXIT GAME";
            this.EXITBUTTON.UseVisualStyleBackColor = false;
            this.EXITBUTTON.Click += new System.EventHandler(this.EXITBUTTON_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 655);
            this.Controls.Add(this.EXITBUTTON);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.BGGAMESTART);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME STARTED!";
            ((System.ComponentModel.ISupportInitialize)(this.BGGAMESTART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BGGAMESTART;
        private CircularPictureBox CB1;
        private System.Windows.Forms.Button EXITBUTTON;
    }
}