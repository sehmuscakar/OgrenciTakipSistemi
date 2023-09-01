namespace OgrenciTakipSistemi
{
    partial class OgrenciForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtogrid = new System.Windows.Forms.TextBox();
            this.btnogrencisil = new System.Windows.Forms.Button();
            this.btnogrenciguncelle = new System.Windows.Forms.Button();
            this.btnogrenciekle = new System.Windows.Forms.Button();
            this.cmbogrhedef = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsinav2 = new System.Windows.Forms.TextBox();
            this.txtsinav1 = new System.Windows.Forms.TextBox();
            this.txtogrenncisoyad = new System.Windows.Forms.TextBox();
            this.txtogrenciad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOgrenci = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtogrid);
            this.groupBox1.Controls.Add(this.btnogrencisil);
            this.groupBox1.Controls.Add(this.btnogrenciguncelle);
            this.groupBox1.Controls.Add(this.btnogrenciekle);
            this.groupBox1.Controls.Add(this.cmbogrhedef);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsinav2);
            this.groupBox1.Controls.Add(this.txtsinav1);
            this.groupBox1.Controls.Add(this.txtogrenncisoyad);
            this.groupBox1.Controls.Add(this.txtogrenciad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci İşlem Paneli";
        //    this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtogrid
            // 
            this.txtogrid.Location = new System.Drawing.Point(678, 10);
            this.txtogrid.Name = "txtogrid";
            this.txtogrid.Size = new System.Drawing.Size(100, 27);
            this.txtogrid.TabIndex = 13;
            this.txtogrid.Visible = false;
            // 
            // btnogrencisil
            // 
            this.btnogrencisil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnogrencisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrencisil.Location = new System.Drawing.Point(554, 184);
            this.btnogrencisil.Name = "btnogrencisil";
            this.btnogrencisil.Size = new System.Drawing.Size(182, 55);
            this.btnogrencisil.TabIndex = 12;
            this.btnogrencisil.Text = "Kayıt Sil";
            this.btnogrencisil.UseVisualStyleBackColor = false;
            this.btnogrencisil.Click += new System.EventHandler(this.btnogrencisil_Click);
            // 
            // btnogrenciguncelle
            // 
            this.btnogrenciguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnogrenciguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrenciguncelle.Location = new System.Drawing.Point(554, 107);
            this.btnogrenciguncelle.Name = "btnogrenciguncelle";
            this.btnogrenciguncelle.Size = new System.Drawing.Size(182, 53);
            this.btnogrenciguncelle.TabIndex = 11;
            this.btnogrenciguncelle.Text = "Kayıt Güncellle";
            this.btnogrenciguncelle.UseVisualStyleBackColor = false;
            this.btnogrenciguncelle.Click += new System.EventHandler(this.btnogrenciguncelle_Click);
            // 
            // btnogrenciekle
            // 
            this.btnogrenciekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnogrenciekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrenciekle.Location = new System.Drawing.Point(554, 34);
            this.btnogrenciekle.Name = "btnogrenciekle";
            this.btnogrenciekle.Size = new System.Drawing.Size(182, 57);
            this.btnogrenciekle.TabIndex = 10;
            this.btnogrenciekle.Text = "Kayıt Ekle";
            this.btnogrenciekle.UseVisualStyleBackColor = false;
            this.btnogrenciekle.Click += new System.EventHandler(this.btnogrenciekle_Click);
            // 
            // cmbogrhedef
            // 
            this.cmbogrhedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbogrhedef.FormattingEnabled = true;
            this.cmbogrhedef.Location = new System.Drawing.Point(227, 216);
            this.cmbogrhedef.Name = "cmbogrhedef";
            this.cmbogrhedef.Size = new System.Drawing.Size(236, 33);
            this.cmbogrhedef.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hedeflenen Bölüm:";
            // 
            // txtsinav2
            // 
            this.txtsinav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsinav2.Location = new System.Drawing.Point(227, 172);
            this.txtsinav2.Name = "txtsinav2";
            this.txtsinav2.Size = new System.Drawing.Size(209, 30);
            this.txtsinav2.TabIndex = 7;
            // 
            // txtsinav1
            // 
            this.txtsinav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsinav1.Location = new System.Drawing.Point(227, 127);
            this.txtsinav1.Name = "txtsinav1";
            this.txtsinav1.Size = new System.Drawing.Size(209, 30);
            this.txtsinav1.TabIndex = 6;
            // 
            // txtogrenncisoyad
            // 
            this.txtogrenncisoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrenncisoyad.Location = new System.Drawing.Point(227, 79);
            this.txtogrenncisoyad.Name = "txtogrenncisoyad";
            this.txtogrenncisoyad.Size = new System.Drawing.Size(209, 30);
            this.txtogrenncisoyad.TabIndex = 5;
            // 
            // txtogrenciad
            // 
            this.txtogrenciad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrenciad.Location = new System.Drawing.Point(227, 37);
            this.txtogrenciad.Name = "txtogrenciad";
            this.txtogrenciad.Size = new System.Drawing.Size(209, 30);
            this.txtogrenciad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alan Yeterlilik Sınavı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temel Yeterlilik Sınavı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // dataGridViewOgrenci
            // 
            this.dataGridViewOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenci.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOgrenci.Name = "dataGridViewOgrenci";
            this.dataGridViewOgrenci.RowHeadersWidth = 51;
            this.dataGridViewOgrenci.RowTemplate.Height = 24;
            this.dataGridViewOgrenci.Size = new System.Drawing.Size(784, 207);
            this.dataGridViewOgrenci.TabIndex = 1;
            this.dataGridViewOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgrenci_CellClick);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(808, 516);
            this.Controls.Add(this.dataGridViewOgrenci);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbogrhedef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsinav2;
        private System.Windows.Forms.TextBox txtsinav1;
        private System.Windows.Forms.TextBox txtogrenncisoyad;
        private System.Windows.Forms.TextBox txtogrenciad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnogrencisil;
        private System.Windows.Forms.Button btnogrenciguncelle;
        private System.Windows.Forms.Button btnogrenciekle;
        private System.Windows.Forms.DataGridView dataGridViewOgrenci;
        private System.Windows.Forms.TextBox txtogrid;
    }
}