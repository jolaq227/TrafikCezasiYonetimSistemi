namespace trafik_cesasi_yonetimi
{
    partial class ana_sayfa
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
            this.cezaEkle = new System.Windows.Forms.Button();
            this.plakaText = new System.Windows.Forms.TextBox();
            this.borcTopla = new System.Windows.Forms.Button();
            this.raporla = new System.Windows.Forms.Button();
            this.tmCzaGrntle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cezaEkle
            // 
            this.cezaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cezaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cezaEkle.Location = new System.Drawing.Point(26, 186);
            this.cezaEkle.Name = "cezaEkle";
            this.cezaEkle.Size = new System.Drawing.Size(221, 101);
            this.cezaEkle.TabIndex = 0;
            this.cezaEkle.Text = "Ceza Ekle";
            this.cezaEkle.UseVisualStyleBackColor = true;
            this.cezaEkle.Click += new System.EventHandler(this.cezaEkle_Click);
            // 
            // plakaText
            // 
            this.plakaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakaText.Location = new System.Drawing.Point(187, 34);
            this.plakaText.Name = "plakaText";
            this.plakaText.Size = new System.Drawing.Size(399, 44);
            this.plakaText.TabIndex = 1;
            // 
            // borcTopla
            // 
            this.borcTopla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.borcTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borcTopla.Location = new System.Drawing.Point(262, 186);
            this.borcTopla.Name = "borcTopla";
            this.borcTopla.Size = new System.Drawing.Size(221, 101);
            this.borcTopla.TabIndex = 2;
            this.borcTopla.Text = "Borç Topla";
            this.borcTopla.UseVisualStyleBackColor = true;
            this.borcTopla.Click += new System.EventHandler(this.borcTopla_Click);
            // 
            // raporla
            // 
            this.raporla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.raporla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporla.Location = new System.Drawing.Point(500, 186);
            this.raporla.Name = "raporla";
            this.raporla.Size = new System.Drawing.Size(221, 101);
            this.raporla.TabIndex = 3;
            this.raporla.Text = "Raporla";
            this.raporla.UseVisualStyleBackColor = true;
            this.raporla.Click += new System.EventHandler(this.raporla_Click);
            // 
            // tmCzaGrntle
            // 
            this.tmCzaGrntle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tmCzaGrntle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmCzaGrntle.Location = new System.Drawing.Point(262, 311);
            this.tmCzaGrntle.Name = "tmCzaGrntle";
            this.tmCzaGrntle.Size = new System.Drawing.Size(221, 101);
            this.tmCzaGrntle.TabIndex = 4;
            this.tmCzaGrntle.Text = "Tüm Cezaları Görüntüle";
            this.tmCzaGrntle.UseVisualStyleBackColor = true;
            this.tmCzaGrntle.Click += new System.EventHandler(this.tmCzaGrntle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plaka:";
            // 
            // ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmCzaGrntle);
            this.Controls.Add(this.raporla);
            this.Controls.Add(this.borcTopla);
            this.Controls.Add(this.plakaText);
            this.Controls.Add(this.cezaEkle);
            this.Name = "ana_sayfa";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cezaEkle;
        private System.Windows.Forms.TextBox plakaText;
        private System.Windows.Forms.Button borcTopla;
        private System.Windows.Forms.Button raporla;
        private System.Windows.Forms.Button tmCzaGrntle;
        private System.Windows.Forms.Label label1;
    }
}