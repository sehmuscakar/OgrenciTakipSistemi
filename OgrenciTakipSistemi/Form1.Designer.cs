namespace OgrenciTakipSistemi
{
    partial class frmanaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmanaform));
            this.btnogrenci = new System.Windows.Forms.Button();
            this.btnhedef = new System.Windows.Forms.Button();
            this.btnegitimkocu = new System.Windows.Forms.Button();
            this.btnbranş = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnogrenci
            // 
            this.btnogrenci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnogrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrenci.Location = new System.Drawing.Point(21, 15);
            this.btnogrenci.Name = "btnogrenci";
            this.btnogrenci.Size = new System.Drawing.Size(339, 85);
            this.btnogrenci.TabIndex = 0;
            this.btnogrenci.Text = "Öğrenci Paneli";
            this.btnogrenci.UseVisualStyleBackColor = false;
            this.btnogrenci.Click += new System.EventHandler(this.btnogrenci_Click);
            // 
            // btnhedef
            // 
            this.btnhedef.BackColor = System.Drawing.Color.Cyan;
            this.btnhedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhedef.Location = new System.Drawing.Point(21, 141);
            this.btnhedef.Name = "btnhedef";
            this.btnhedef.Size = new System.Drawing.Size(339, 89);
            this.btnhedef.TabIndex = 1;
            this.btnhedef.Text = "Öğrenci Hedef Paneli";
            this.btnhedef.UseVisualStyleBackColor = false;
            this.btnhedef.Click += new System.EventHandler(this.btnbranşvehedef_Click);
            // 
            // btnegitimkocu
            // 
            this.btnegitimkocu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnegitimkocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnegitimkocu.Location = new System.Drawing.Point(21, 398);
            this.btnegitimkocu.Name = "btnegitimkocu";
            this.btnegitimkocu.Size = new System.Drawing.Size(339, 83);
            this.btnegitimkocu.TabIndex = 2;
            this.btnegitimkocu.Text = "Eğitim Koçu Paneli";
            this.btnegitimkocu.UseVisualStyleBackColor = false;
            this.btnegitimkocu.Click += new System.EventHandler(this.btnegitimkocu_Click);
            // 
            // btnbranş
            // 
            this.btnbranş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbranş.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbranş.Location = new System.Drawing.Point(21, 274);
            this.btnbranş.Name = "btnbranş";
            this.btnbranş.Size = new System.Drawing.Size(339, 83);
            this.btnbranş.TabIndex = 3;
            this.btnbranş.Text = "Eğitmen Branş Paneli";
            this.btnbranş.UseVisualStyleBackColor = false;
            this.btnbranş.Click += new System.EventHandler(this.btnbranş_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(675, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(379, 38);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // frmanaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 515);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbranş);
            this.Controls.Add(this.btnegitimkocu);
            this.Controls.Add(this.btnhedef);
            this.Controls.Add(this.btnogrenci);
            this.Name = "frmanaform";
            this.Text = "AnaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnogrenci;
        private System.Windows.Forms.Button btnhedef;
        private System.Windows.Forms.Button btnegitimkocu;
        private System.Windows.Forms.Button btnbranş;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

