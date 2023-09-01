namespace OgrenciTakipSistemi
{
    partial class EgitmenBranş
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
            this.txtbranşid = new System.Windows.Forms.TextBox();
            this.txtbrans = new System.Windows.Forms.TextBox();
            this.btnbranşsil = new System.Windows.Forms.Button();
            this.btnbranşguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbranşekle = new System.Windows.Forms.Button();
            this.dataGridViewbranch = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbranch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbranşid);
            this.groupBox1.Controls.Add(this.txtbrans);
            this.groupBox1.Controls.Add(this.btnbranşsil);
            this.groupBox1.Controls.Add(this.btnbranşguncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnbranşekle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 283);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branş İşlemleri";
            // 
            // txtbranşid
            // 
            this.txtbranşid.Location = new System.Drawing.Point(484, 29);
            this.txtbranşid.Name = "txtbranşid";
            this.txtbranşid.Size = new System.Drawing.Size(96, 30);
            this.txtbranşid.TabIndex = 19;
            this.txtbranşid.Visible = false;
            // 
            // txtbrans
            // 
            this.txtbrans.Location = new System.Drawing.Point(101, 37);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(235, 30);
            this.txtbrans.TabIndex = 17;
            // 
            // btnbranşsil
            // 
            this.btnbranşsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbranşsil.Location = new System.Drawing.Point(93, 210);
            this.btnbranşsil.Name = "btnbranşsil";
            this.btnbranşsil.Size = new System.Drawing.Size(232, 49);
            this.btnbranşsil.TabIndex = 16;
            this.btnbranşsil.Text = "Branş Sil";
            this.btnbranşsil.UseVisualStyleBackColor = false;
            // 
            // btnbranşguncelle
            // 
            this.btnbranşguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbranşguncelle.Location = new System.Drawing.Point(93, 148);
            this.btnbranşguncelle.Name = "btnbranşguncelle";
            this.btnbranşguncelle.Size = new System.Drawing.Size(232, 50);
            this.btnbranşguncelle.TabIndex = 15;
            this.btnbranşguncelle.Text = "Branş Güncellle";
            this.btnbranşguncelle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Branşlar:";
            // 
            // btnbranşekle
            // 
            this.btnbranşekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbranşekle.Location = new System.Drawing.Point(93, 84);
            this.btnbranşekle.Name = "btnbranşekle";
            this.btnbranşekle.Size = new System.Drawing.Size(232, 56);
            this.btnbranşekle.TabIndex = 14;
            this.btnbranşekle.Text = "Branş Ekle";
            this.btnbranşekle.UseVisualStyleBackColor = false;
            // 
            // dataGridViewbranch
            // 
            this.dataGridViewbranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbranch.Location = new System.Drawing.Point(-1, 3);
            this.dataGridViewbranch.Name = "dataGridViewbranch";
            this.dataGridViewbranch.RowHeadersWidth = 51;
            this.dataGridViewbranch.RowTemplate.Height = 24;
            this.dataGridViewbranch.Size = new System.Drawing.Size(586, 207);
            this.dataGridViewbranch.TabIndex = 8;
            // 
            // EgitmenBranş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewbranch);
            this.Name = "EgitmenBranş";
            this.Text = "EgitmenBranş";
            this.Load += new System.EventHandler(this.EgitmenBranş_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbranch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbranşid;
        private System.Windows.Forms.TextBox txtbrans;
        private System.Windows.Forms.Button btnbranşsil;
        private System.Windows.Forms.Button btnbranşguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbranşekle;
        private System.Windows.Forms.DataGridView dataGridViewbranch;
    }
}