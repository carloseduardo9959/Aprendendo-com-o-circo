namespace Circo
{
    partial class frmNv1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.cmdPoucas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Circo.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(1447, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(491, 143);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(321, 22);
            this.txtTeste.TabIndex = 1;
            // 
            // cmdPoucas
            // 
            this.cmdPoucas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmdPoucas.Location = new System.Drawing.Point(572, 521);
            this.cmdPoucas.Name = "cmdPoucas";
            this.cmdPoucas.Size = new System.Drawing.Size(205, 70);
            this.cmdPoucas.TabIndex = 2;
            this.cmdPoucas.Text = "Poucas";
            this.cmdPoucas.UseVisualStyleBackColor = false;
            // 
            // frmNv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Circo.Properties.Resources.Nivel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 603);
            this.Controls.Add(this.cmdPoucas);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNv1";
            this.Text = "Aprendendo com o Circo";
            this.Load += new System.EventHandler(this.frmNv1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTeste;
        private System.Windows.Forms.Button cmdPoucas;
    }
}