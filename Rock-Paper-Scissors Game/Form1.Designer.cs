﻿namespace Rock_Paper_Scissors_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.STARTBUTTON = new System.Windows.Forms.Button();
            this.EXITBUTTON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(145, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1156, 145);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROCK PAPER SCISSORS";
            // 
            // STARTBUTTON
            // 
            this.STARTBUTTON.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STARTBUTTON.Location = new System.Drawing.Point(623, 289);
            this.STARTBUTTON.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.STARTBUTTON.Name = "STARTBUTTON";
            this.STARTBUTTON.Size = new System.Drawing.Size(223, 57);
            this.STARTBUTTON.TabIndex = 1;
            this.STARTBUTTON.Text = "START";
            this.STARTBUTTON.UseVisualStyleBackColor = true;
            // 
            // EXITBUTTON
            // 
            this.EXITBUTTON.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXITBUTTON.Location = new System.Drawing.Point(623, 416);
            this.EXITBUTTON.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EXITBUTTON.Name = "EXITBUTTON";
            this.EXITBUTTON.Size = new System.Drawing.Size(223, 57);
            this.EXITBUTTON.TabIndex = 1;
            this.EXITBUTTON.Text = "EXIT GAME";
            this.EXITBUTTON.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(525, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "MADE BY BUNGPEERAPAT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1408, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EXITBUTTON);
            this.Controls.Add(this.STARTBUTTON);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "R-P-S GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button STARTBUTTON;
        private System.Windows.Forms.Button EXITBUTTON;
        private System.Windows.Forms.Label label2;
    }
}

