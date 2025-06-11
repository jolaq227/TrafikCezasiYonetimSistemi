namespace trafik_cesasi_yonetimi
{
    partial class ceza_ekle
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cezaEkleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cezaTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plakaField = new System.Windows.Forms.TextBox();
            this.adiField = new System.Windows.Forms.TextBox();
            this.soyadiField = new System.Windows.Forms.TextBox();
            this.telefonField = new System.Windows.Forms.TextBox();
            this.TCNoField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cezaEkleBtn
            // 
            this.cezaEkleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cezaEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cezaEkleBtn.Location = new System.Drawing.Point(12, 188);
            this.cezaEkleBtn.Name = "cezaEkleBtn";
            this.cezaEkleBtn.Size = new System.Drawing.Size(377, 34);
            this.cezaEkleBtn.TabIndex = 2;
            this.cezaEkleBtn.Text = "Ceza ekle";
            this.cezaEkleBtn.UseVisualStyleBackColor = false;
            this.cezaEkleBtn.Click += new System.EventHandler(this.cezaEklebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ceza Türü:";
            // 
            // cezaTuru
            // 
            this.cezaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cezaTuru.FormattingEnabled = true;
            this.cezaTuru.Items.AddRange(new object[] {
            "Hız Cezası",
            "Park Cezası",
            "Kırmısı Işık Cezası"});
            this.cezaTuru.Location = new System.Drawing.Point(158, 8);
            this.cezaTuru.Name = "cezaTuru";
            this.cezaTuru.Size = new System.Drawing.Size(231, 28);
            this.cezaTuru.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sürücü Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sürücü Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sürücü Telefonu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plaka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sürücü TC No:";
            // 
            // plakaField
            // 
            this.plakaField.Location = new System.Drawing.Point(158, 43);
            this.plakaField.Name = "plakaField";
            this.plakaField.Size = new System.Drawing.Size(231, 20);
            this.plakaField.TabIndex = 15;
            // 
            // adiField
            // 
            this.adiField.Location = new System.Drawing.Point(158, 96);
            this.adiField.Name = "adiField";
            this.adiField.Size = new System.Drawing.Size(231, 20);
            this.adiField.TabIndex = 16;
            // 
            // soyadiField
            // 
            this.soyadiField.Location = new System.Drawing.Point(158, 121);
            this.soyadiField.Name = "soyadiField";
            this.soyadiField.Size = new System.Drawing.Size(231, 20);
            this.soyadiField.TabIndex = 17;
            // 
            // telefonField
            // 
            this.telefonField.Location = new System.Drawing.Point(158, 150);
            this.telefonField.Name = "telefonField";
            this.telefonField.Size = new System.Drawing.Size(231, 20);
            this.telefonField.TabIndex = 19;
            // 
            // TCNoField
            // 
            this.TCNoField.Location = new System.Drawing.Point(158, 69);
            this.TCNoField.Name = "TCNoField";
            this.TCNoField.Size = new System.Drawing.Size(231, 20);
            this.TCNoField.TabIndex = 20;
            // 
            // ceza_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 270);
            this.Controls.Add(this.TCNoField);
            this.Controls.Add(this.telefonField);
            this.Controls.Add(this.soyadiField);
            this.Controls.Add(this.adiField);
            this.Controls.Add(this.plakaField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cezaTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cezaEkleBtn);
            this.Name = "ceza_ekle";
            this.Text = "Ceza Ekleme";
            this.Load += new System.EventHandler(this.ceza_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cezaEkleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cezaTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox plakaField;
        private System.Windows.Forms.TextBox adiField;
        private System.Windows.Forms.TextBox soyadiField;
        private System.Windows.Forms.TextBox telefonField;
        private System.Windows.Forms.TextBox TCNoField;
    }
}

