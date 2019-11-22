namespace Circo
{
    partial class frmParabensnv1
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
            this.cmdClose = new System.Windows.Forms.PictureBox();
            this.cmdContinuar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.Image = global::Circo.Properties.Resources.close1;
            this.cmdClose.Location = new System.Drawing.Point(1446, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(60, 60);
            this.cmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdClose.TabIndex = 0;
            this.cmdClose.TabStop = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdContinuar
            // 
            this.cmdContinuar.AutoSize = true;
            this.cmdContinuar.BackColor = System.Drawing.Color.Transparent;
            this.cmdContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdContinuar.Location = new System.Drawing.Point(675, 506);
            this.cmdContinuar.Name = "cmdContinuar";
            this.cmdContinuar.Size = new System.Drawing.Size(225, 55);
            this.cmdContinuar.TabIndex = 1;
            this.cmdContinuar.Text = "Continue";
            this.cmdContinuar.Click += new System.EventHandler(this.cmdContinuar_Click);
            // 
            // frmParabensnv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Circo.Properties.Resources.finalnv1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 603);
            this.Controls.Add(this.cmdContinuar);
            this.Controls.Add(this.cmdClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParabensnv1";
            this.Text = "frmParabensnv1";
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cmdClose;
        private System.Windows.Forms.Label cmdContinuar;
    }
}