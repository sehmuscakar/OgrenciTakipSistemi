namespace OgrenciTakipSistemi
{
    partial class Target
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txthedefid = new System.Windows.Forms.TextBox();
            this.txthedef = new System.Windows.Forms.TextBox();
            this.btnhedefsil = new System.Windows.Forms.Button();
            this.btnhedefguncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnhedefeklee = new System.Windows.Forms.Button();
            this.dataGridViewtarget = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtarget)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txthedefid);
            this.groupBox2.Controls.Add(this.txthedef);
            this.groupBox2.Controls.Add(this.btnhedefsil);
            this.groupBox2.Controls.Add(this.btnhedefguncelle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnhedefeklee);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 263);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hedef İşlemleri";
            // 
            // txthedefid
            // 
            this.txthedefid.Location = new System.Drawing.Point(366, 20);
            this.txthedefid.Name = "txthedefid";
            this.txthedefid.Size = new System.Drawing.Size(96, 30);
            this.txthedefid.TabIndex = 18;
            this.txthedefid.Visible = false;
            // 
            // txthedef
            // 
            this.txthedef.Location = new System.Drawing.Point(101, 37);
            this.txthedef.Name = "txthedef";
            this.txthedef.Size = new System.Drawing.Size(202, 30);
            this.txthedef.TabIndex = 17;
            // 
            // btnhedefsil
            // 
            this.btnhedefsil.BackColor = System.Drawing.Color.Yellow;
            this.btnhedefsil.Location = new System.Drawing.Point(101, 202);
            this.btnhedefsil.Name = "btnhedefsil";
            this.btnhedefsil.Size = new System.Drawing.Size(202, 41);
            this.btnhedefsil.TabIndex = 16;
            this.btnhedefsil.Text = "Hedef Sil";
            this.btnhedefsil.UseVisualStyleBackColor = false;
            this.btnhedefsil.Click += new System.EventHandler(this.btnhedefsil_Click);
            // 
            // btnhedefguncelle
            // 
            this.btnhedefguncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnhedefguncelle.Location = new System.Drawing.Point(101, 143);
            this.btnhedefguncelle.Name = "btnhedefguncelle";
            this.btnhedefguncelle.Size = new System.Drawing.Size(202, 50);
            this.btnhedefguncelle.TabIndex = 15;
            this.btnhedefguncelle.Text = "Hedef Güncellle";
            this.btnhedefguncelle.UseVisualStyleBackColor = false;
            this.btnhedefguncelle.Click += new System.EventHandler(this.btnhedefguncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hedefler:";
            // 
            // btnhedefeklee
            // 
            this.btnhedefeklee.BackColor = System.Drawing.Color.Yellow;
            this.btnhedefeklee.Location = new System.Drawing.Point(101, 84);
            this.btnhedefeklee.Name = "btnhedefeklee";
            this.btnhedefeklee.Size = new System.Drawing.Size(202, 48);
            this.btnhedefeklee.TabIndex = 14;
            this.btnhedefeklee.Text = "Hedef  Ekle";
            this.btnhedefeklee.UseVisualStyleBackColor = false;
            this.btnhedefeklee.Click += new System.EventHandler(this.btnhedefeklee_Click);
            // 
            // dataGridViewtarget
            // 
            this.dataGridViewtarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtarget.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewtarget.Name = "dataGridViewtarget";
            this.dataGridViewtarget.RowHeadersWidth = 51;
            this.dataGridViewtarget.RowTemplate.Height = 24;
            this.dataGridViewtarget.Size = new System.Drawing.Size(509, 332);
            this.dataGridViewtarget.TabIndex = 4;
            this.dataGridViewtarget.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtarget_CellClick);
            // 
            // Target
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(519, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewtarget);
            this.Name = "Target";
            this.Text = "Target Formu";
            this.Load += new System.EventHandler(this.frmTargetandBranch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnhedefsil;
        private System.Windows.Forms.Button btnhedefguncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnhedefeklee;
        private System.Windows.Forms.TextBox txthedef;
        private System.Windows.Forms.TextBox txthedefid;
        private System.Windows.Forms.DataGridView dataGridViewtarget;
    }
}