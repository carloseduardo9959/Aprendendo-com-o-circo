namespace Circo
{
    partial class frmNivel3
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
            this.animal1 = new System.Windows.Forms.PictureBox();
            this.animal2 = new System.Windows.Forms.PictureBox();
            this.animal4 = new System.Windows.Forms.PictureBox();
            this.animal5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrandes = new System.Windows.Forms.Label();
            this.lblPequenos = new System.Windows.Forms.Label();
            this.cmdConcluido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.animal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animal1
            // 
            this.animal1.BackColor = System.Drawing.Color.Transparent;
            this.animal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal1.Image = global::Circo.Properties.Resources.Leão1;
            this.animal1.Location = new System.Drawing.Point(205, 222);
            this.animal1.Name = "animal1";
            this.animal1.Size = new System.Drawing.Size(200, 200);
            this.animal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal1.TabIndex = 1;
            this.animal1.TabStop = false;
            this.animal1.Click += new System.EventHandler(this.animal1_Click);
            // 
            // animal2
            // 
            this.animal2.BackColor = System.Drawing.Color.Transparent;
            this.animal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal2.Image = global::Circo.Properties.Resources.Cachorro;
            this.animal2.Location = new System.Drawing.Point(411, 222);
            this.animal2.Name = "animal2";
            this.animal2.Size = new System.Drawing.Size(200, 200);
            this.animal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal2.TabIndex = 2;
            this.animal2.TabStop = false;
            this.animal2.Click += new System.EventHandler(this.animal2_Click);
            // 
            // animal4
            // 
            this.animal4.BackColor = System.Drawing.Color.Transparent;
            this.animal4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal4.Image = global::Circo.Properties.Resources.Coelho;
            this.animal4.Location = new System.Drawing.Point(823, 222);
            this.animal4.Name = "animal4";
            this.animal4.Size = new System.Drawing.Size(200, 200);
            this.animal4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal4.TabIndex = 4;
            this.animal4.TabStop = false;
            this.animal4.Click += new System.EventHandler(this.animal4_Click);
            // 
            // animal5
            // 
            this.animal5.BackColor = System.Drawing.Color.Transparent;
            this.animal5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal5.Image = global::Circo.Properties.Resources.Elefante;
            this.animal5.Location = new System.Drawing.Point(1029, 222);
            this.animal5.Name = "animal5";
            this.animal5.Size = new System.Drawing.Size(200, 200);
            this.animal5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal5.TabIndex = 5;
            this.animal5.TabStop = false;
            this.animal5.Click += new System.EventHandler(this.animal5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Animais Selecionados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Animais Grandes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Animais Pequenos:";
            // 
            // lblGrandes
            // 
            this.lblGrandes.AutoSize = true;
            this.lblGrandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandes.Location = new System.Drawing.Point(462, 489);
            this.lblGrandes.Name = "lblGrandes";
            this.lblGrandes.Size = new System.Drawing.Size(32, 32);
            this.lblGrandes.TabIndex = 11;
            this.lblGrandes.Text = "0";
            // 
            // lblPequenos
            // 
            this.lblPequenos.AutoSize = true;
            this.lblPequenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPequenos.Location = new System.Drawing.Point(483, 536);
            this.lblPequenos.Name = "lblPequenos";
            this.lblPequenos.Size = new System.Drawing.Size(32, 32);
            this.lblPequenos.TabIndex = 12;
            this.lblPequenos.Text = "0";
            // 
            // cmdConcluido
            // 
            this.cmdConcluido.AutoSize = true;
            this.cmdConcluido.BackColor = System.Drawing.Color.Black;
            this.cmdConcluido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConcluido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdConcluido.Location = new System.Drawing.Point(686, 590);
            this.cmdConcluido.Name = "cmdConcluido";
            this.cmdConcluido.Size = new System.Drawing.Size(168, 51);
            this.cmdConcluido.TabIndex = 13;
            this.cmdConcluido.Text = "Pronto!";
            this.cmdConcluido.Click += new System.EventHandler(this.cmdConcluido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Circo.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(1464, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmNivel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Circo.Properties.Resources.Nivel3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1536, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdConcluido);
            this.Controls.Add(this.lblPequenos);
            this.Controls.Add(this.lblGrandes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animal5);
            this.Controls.Add(this.animal4);
            this.Controls.Add(this.animal2);
            this.Controls.Add(this.animal1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNivel3";
            this.Text = "frmNivel3";
            ((System.ComponentModel.ISupportInitialize)(this.animal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox animal1;
        private System.Windows.Forms.PictureBox animal2;
        private System.Windows.Forms.PictureBox animal4;
        private System.Windows.Forms.PictureBox animal5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrandes;
        private System.Windows.Forms.Label lblPequenos;
        private System.Windows.Forms.Label cmdConcluido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}