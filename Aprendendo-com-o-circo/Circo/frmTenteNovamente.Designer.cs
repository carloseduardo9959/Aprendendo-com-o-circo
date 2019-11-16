namespace Circo
{
    partial class frmTenteNovamente
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
            this.SuspendLayout();
            // 
            // cmdContinuar
            // 
            this.cmdContinuar.AutoSize = true;
            this.cmdContinuar.BackColor = System.Drawing.Color.Transparent;
            this.cmdContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdContinuar.Location = new System.Drawing.Point(675, 501);
            this.cmdContinuar.Name = "cmdContinuar";
            this.cmdContinuar.Size = new System.Drawing.Size(225, 55);
            this.cmdContinuar.TabIndex = 2;
            this.cmdContinuar.Text = "Continue";
            this.cmdContinuar.Click += new System.EventHandler(this.cmdContinuar_Click);
            // 
            // frmTenteNovamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Circo.Properties.Resources.Tente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 603);
            this.Controls.Add(this.cmdContinuar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTenteNovamente";
            this.Text = "frmTenteNovamente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmdContinuar;
    }
}