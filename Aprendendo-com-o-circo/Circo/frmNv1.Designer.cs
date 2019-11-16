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
            this.cmdPoucas = new System.Windows.Forms.Label();
            this.cmdMuitas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.txtTeste.Enabled = false;
            this.txtTeste.Location = new System.Drawing.Point(12, 580);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(21, 22);
            this.txtTeste.TabIndex = 1;
            // 
            // cmdPoucas
            // 
            this.cmdPoucas.AutoSize = true;
            this.cmdPoucas.BackColor = System.Drawing.Color.Transparent;
            this.cmdPoucas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPoucas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPoucas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdPoucas.Location = new System.Drawing.Point(586, 535);
            this.cmdPoucas.Name = "cmdPoucas";
            this.cmdPoucas.Size = new System.Drawing.Size(174, 52);
            this.cmdPoucas.TabIndex = 4;
            this.cmdPoucas.Text = "Poucas";
            this.cmdPoucas.Click += new System.EventHandler(this.cmdPoucas_Click);
            // 
            // cmdMuitas
            // 
            this.cmdMuitas.AutoSize = true;
            this.cmdMuitas.BackColor = System.Drawing.Color.Transparent;
            this.cmdMuitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdMuitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMuitas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdMuitas.Location = new System.Drawing.Point(915, 537);
            this.cmdMuitas.Name = "cmdMuitas";
            this.cmdMuitas.Size = new System.Drawing.Size(158, 52);
            this.cmdMuitas.TabIndex = 5;
            this.cmdMuitas.Text = "Muitas";
            this.cmdMuitas.Click += new System.EventHandler(this.cmdMuitas_Click);
            // 
            // frmNv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Circo.Properties.Resources.Nivel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 603);
            this.Controls.Add(this.cmdMuitas);
            this.Controls.Add(this.cmdPoucas);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label cmdPoucas;
        private System.Windows.Forms.Label cmdMuitas;
    }
}