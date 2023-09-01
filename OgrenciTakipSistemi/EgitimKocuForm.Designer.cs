namespace OgrenciTakipSistemi
{
    partial class EgitimKocuForm
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
            this.dataGridViewegitimkoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEGİTMENid = new System.Windows.Forms.TextBox();
            this.btnegitmensil = new System.Windows.Forms.Button();
            this.btnEgitmenguncelle = new System.Windows.Forms.Button();
            this.btnegitmenekle = new System.Windows.Forms.Button();
            this.cmbogrhedef = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtegitmensoyad = new System.Windows.Forms.TextBox();
            this.txtegitmenad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewegitimkoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewegitimkoc
            // 
            this.dataGridViewegitimkoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewegitimkoc.Location = new System.Drawing.Point(14, 11);
            this.dataGridViewegitimkoc.Name = "dataGridViewegitimkoc";
            this.dataGridViewegitimkoc.RowHeadersWidth = 51;
            this.dataGridViewegitimkoc.RowTemplate.Height = 24;
            this.dataGridViewegitimkoc.Size = new System.Drawing.Size(801, 207);
            this.dataGridViewegitimkoc.TabIndex = 3;
            this.dataGridViewegitimkoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewegitimkoc_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEGİTMENid);
            this.groupBox1.Controls.Add(this.btnegitmensil);
            this.groupBox1.Controls.Add(this.btnEgitmenguncelle);
            this.groupBox1.Controls.Add(this.btnegitmenekle);
            this.groupBox1.Controls.Add(this.cmbogrhedef);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtegitmensoyad);
            this.groupBox1.Controls.Add(this.txtegitmenad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci İşlem Paneli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 37);
            this.comboBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Eiğitmen Tecrübesi:";
            // 
            // txtEGİTMENid
            // 
            this.txtEGİTMENid.Location = new System.Drawing.Point(695, 16);
            this.txtEGİTMENid.Name = "txtEGİTMENid";
            this.txtEGİTMENid.Size = new System.Drawing.Size(100, 34);
            this.txtEGİTMENid.TabIndex = 13;
            this.txtEGİTMENid.Visible = false;
            // 
            // btnegitmensil
            // 
            this.btnegitmensil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnegitmensil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnegitmensil.Location = new System.Drawing.Point(570, 187);
            this.btnegitmensil.Name = "btnegitmensil";
            this.btnegitmensil.Size = new System.Drawing.Size(210, 50);
            this.btnegitmensil.TabIndex = 12;
            this.btnegitmensil.Text = "Kayıt Sil";
            this.btnegitmensil.UseVisualStyleBackColor = false;
            this.btnegitmensil.Click += new System.EventHandler(this.btnegitmensil_Click);
            // 
            // btnEgitmenguncelle
            // 
            this.btnEgitmenguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEgitmenguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitmenguncelle.Location = new System.Drawing.Point(570, 123);
            this.btnEgitmenguncelle.Name = "btnEgitmenguncelle";
            this.btnEgitmenguncelle.Size = new System.Drawing.Size(210, 58);
            this.btnEgitmenguncelle.TabIndex = 11;
            this.btnEgitmenguncelle.Text = "Kayıt Güncellle";
            this.btnEgitmenguncelle.UseVisualStyleBackColor = false;
            this.btnEgitmenguncelle.Click += new System.EventHandler(this.btnEgitmenguncelle_Click);
            // 
            // btnegitmenekle
            // 
            this.btnegitmenekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnegitmenekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnegitmenekle.Location = new System.Drawing.Point(570, 60);
            this.btnegitmenekle.Name = "btnegitmenekle";
            this.btnegitmenekle.Size = new System.Drawing.Size(210, 57);
            this.btnegitmenekle.TabIndex = 10;
            this.btnegitmenekle.Text = "Kayıt Ekle";
            this.btnegitmenekle.UseVisualStyleBackColor = false;
            this.btnegitmenekle.Click += new System.EventHandler(this.btnegitmenekle_Click);
            // 
            // cmbogrhedef
            // 
            this.cmbogrhedef.FormattingEnabled = true;
            this.cmbogrhedef.Location = new System.Drawing.Point(240, 144);
            this.cmbogrhedef.Name = "cmbogrhedef";
            this.cmbogrhedef.Size = new System.Drawing.Size(288, 37);
            this.cmbogrhedef.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Eiğitmen Branşı:";
            // 
            // txtegitmensoyad
            // 
            this.txtegitmensoyad.Location = new System.Drawing.Point(240, 100);
            this.txtegitmensoyad.Name = "txtegitmensoyad";
            this.txtegitmensoyad.Size = new System.Drawing.Size(284, 34);
            this.txtegitmensoyad.TabIndex = 5;
            // 
            // txtegitmenad
            // 
            this.txtegitmenad.Location = new System.Drawing.Point(240, 53);
            this.txtegitmenad.Name = "txtegitmenad";
            this.txtegitmenad.Size = new System.Drawing.Size(284, 34);
            this.txtegitmenad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // EgitimKocuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(827, 489);
            this.Controls.Add(this.dataGridViewegitimkoc);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EgitimKocuForm";
            this.Text = "EgitimKocuForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewegitimkoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewegitimkoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEGİTMENid;
        private System.Windows.Forms.Button btnegitmensil;
        private System.Windows.Forms.Button btnEgitmenguncelle;
        private System.Windows.Forms.Button btnegitmenekle;
        private System.Windows.Forms.ComboBox cmbogrhedef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtegitmensoyad;
        private System.Windows.Forms.TextBox txtegitmenad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}