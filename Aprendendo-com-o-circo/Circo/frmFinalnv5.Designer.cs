﻿namespace Circo
{
    partial class frmFinalnv5
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
            this.cmdContinuar = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdContinuar
            // 
            this.cmdContinuar.AutoSize = true;
            this.cmdContinuar.BackColor = System.Drawing.Color.Transparent;
            this.cmdContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdContinuar.Location = new System.Drawing.Point(548, 435);
            this.cmdContinuar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cmdContinuar.Name = "cmdContinuar";
            this.cmdContinuar.Size = new System.Drawing.Size(180, 44);
            this.cmdContinuar.TabIndex = 7;
            this.cmdContinuar.Text = "Continue";
            this.cmdContinuar.Click += new System.EventHandler(this.cmdContinuar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.Image = global::Circo.Properties.Resources.close1;
            this.cmdClose.Location = new System.Drawing.Point(1308, 11);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(45, 49);
            this.cmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdClose.TabIndex = 6;
            this.cmdClose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Circo.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(1173, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmFinalnv5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Circo.Properties.Resources.finalnv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdContinuar);
            this.Controls.Add(this.cmdClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinalnv5";
            this.Text = "frmFinalnv5";
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmdContinuar;
        private System.Windows.Forms.PictureBox cmdClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}