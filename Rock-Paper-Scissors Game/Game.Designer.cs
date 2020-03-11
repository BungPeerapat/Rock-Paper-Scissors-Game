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
            this.CB1 = new System.Windows.Forms.PictureBox();
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
            // 
            // CB1
            // 
            this.CB1.Image = ((System.Drawing.Image)(resources.GetObject("CB1.Image")));
            this.CB1.Location = new System.Drawing.Point(170, 31);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(476, 479);
            this.CB1.TabIndex = 1;
            this.CB1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 655);
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
        private System.Windows.Forms.PictureBox CB1;
    }
}