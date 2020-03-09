namespace Rock_Paper_Scissors_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.STARTBUTTON = new System.Windows.Forms.Button();
            this.EXITBUTTON = new System.Windows.Forms.Button();
            this.RPSG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // STARTBUTTON
            // 
            this.STARTBUTTON.BackColor = System.Drawing.Color.Transparent;
            this.STARTBUTTON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("STARTBUTTON.BackgroundImage")));
            this.STARTBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.STARTBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STARTBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.STARTBUTTON.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STARTBUTTON.ForeColor = System.Drawing.Color.Firebrick;
            this.STARTBUTTON.Location = new System.Drawing.Point(366, 296);
            this.STARTBUTTON.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.STARTBUTTON.Name = "STARTBUTTON";
            this.STARTBUTTON.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.STARTBUTTON.Size = new System.Drawing.Size(116, 92);
            this.STARTBUTTON.TabIndex = 1;
            this.STARTBUTTON.UseVisualStyleBackColor = false;
            // 
            // EXITBUTTON
            // 
            this.EXITBUTTON.BackColor = System.Drawing.Color.PapayaWhip;
            this.EXITBUTTON.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXITBUTTON.ForeColor = System.Drawing.Color.Firebrick;
            this.EXITBUTTON.Location = new System.Drawing.Point(309, 509);
            this.EXITBUTTON.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EXITBUTTON.Name = "EXITBUTTON";
            this.EXITBUTTON.Size = new System.Drawing.Size(223, 57);
            this.EXITBUTTON.TabIndex = 1;
            this.EXITBUTTON.Text = "EXIT GAME";
            this.EXITBUTTON.UseVisualStyleBackColor = false;
            // 
            // RPSG
            // 
            this.RPSG.AutoSize = true;
            this.RPSG.Font = new System.Drawing.Font("Franxurter Totally Fat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPSG.ForeColor = System.Drawing.Color.Firebrick;
            this.RPSG.Location = new System.Drawing.Point(160, 61);
            this.RPSG.Name = "RPSG";
            this.RPSG.Size = new System.Drawing.Size(695, 60);
            this.RPSG.TabIndex = 3;
            this.RPSG.Text = "ROCK PAPER SCISSOR GAME";
            this.RPSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franxurter Totally Fat", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(472, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "MADE BY MASHIRO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(840, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RPSG);
            this.Controls.Add(this.EXITBUTTON);
            this.Controls.Add(this.STARTBUTTON);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R-P-S GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button STARTBUTTON;
        private System.Windows.Forms.Button EXITBUTTON;
        private System.Windows.Forms.Label RPSG;
        private System.Windows.Forms.Label label1;
    }
}

