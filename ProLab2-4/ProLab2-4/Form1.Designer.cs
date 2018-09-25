namespace ProLab2_4
{
    partial class Form1
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
            this.Kayıt_Ekle = new System.Windows.Forms.Button();
            this.Kayıt_Sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sehirAramacomboBox = new System.Windows.Forms.ComboBox();
            this.minAramatextBox = new System.Windows.Forms.TextBox();
            this.maxAramatextBox = new System.Windows.Forms.TextBox();
            this.yakitAramacomboBox = new System.Windows.Forms.ComboBox();
            this.vitesAramaComboBox = new System.Windows.Forms.ComboBox();
            this.minKmtextBox = new System.Windows.Forms.TextBox();
            this.maxKmtextBox = new System.Windows.Forms.TextBox();
            this.renkAramacomboBox = new System.Windows.Forms.ComboBox();
            this.ilanAramacomboBox = new System.Windows.Forms.ComboBox();
            this.Arama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kayıt_Ekle
            // 
            this.Kayıt_Ekle.Location = new System.Drawing.Point(12, 12);
            this.Kayıt_Ekle.Name = "Kayıt_Ekle";
            this.Kayıt_Ekle.Size = new System.Drawing.Size(132, 33);
            this.Kayıt_Ekle.TabIndex = 0;
            this.Kayıt_Ekle.Text = "Kayıt Ekle";
            this.Kayıt_Ekle.UseVisualStyleBackColor = true;
            this.Kayıt_Ekle.Click += new System.EventHandler(this.Kayıt_Ekle_Click);
            // 
            // Kayıt_Sil
            // 
            this.Kayıt_Sil.Location = new System.Drawing.Point(12, 51);
            this.Kayıt_Sil.Name = "Kayıt_Sil";
            this.Kayıt_Sil.Size = new System.Drawing.Size(132, 33);
            this.Kayıt_Sil.TabIndex = 1;
            this.Kayıt_Sil.Text = "Kayıt Sil";
            this.Kayıt_Sil.UseVisualStyleBackColor = true;
            this.Kayıt_Sil.Click += new System.EventHandler(this.Kayıt_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 405);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sehirAramacomboBox
            // 
            this.sehirAramacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sehirAramacomboBox.FormattingEnabled = true;
            this.sehirAramacomboBox.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Bursa",
            "Eskişehir",
            "İstanbul",
            "Kocaeli",
            "Samsun",
            "Trabzon"});
            this.sehirAramacomboBox.Location = new System.Drawing.Point(12, 101);
            this.sehirAramacomboBox.Name = "sehirAramacomboBox";
            this.sehirAramacomboBox.Size = new System.Drawing.Size(132, 21);
            this.sehirAramacomboBox.TabIndex = 4;
            // 
            // minAramatextBox
            // 
            this.minAramatextBox.Location = new System.Drawing.Point(58, 128);
            this.minAramatextBox.Name = "minAramatextBox";
            this.minAramatextBox.Size = new System.Drawing.Size(60, 20);
            this.minAramatextBox.TabIndex = 5;
            this.minAramatextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxAramatextBox
            // 
            this.maxAramatextBox.Location = new System.Drawing.Point(58, 161);
            this.maxAramatextBox.Name = "maxAramatextBox";
            this.maxAramatextBox.Size = new System.Drawing.Size(60, 20);
            this.maxAramatextBox.TabIndex = 6;
            this.maxAramatextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yakitAramacomboBox
            // 
            this.yakitAramacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yakitAramacomboBox.FormattingEnabled = true;
            this.yakitAramacomboBox.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Lpg&Benzin"});
            this.yakitAramacomboBox.Location = new System.Drawing.Point(12, 187);
            this.yakitAramacomboBox.Name = "yakitAramacomboBox";
            this.yakitAramacomboBox.Size = new System.Drawing.Size(132, 21);
            this.yakitAramacomboBox.TabIndex = 7;
            // 
            // vitesAramaComboBox
            // 
            this.vitesAramaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vitesAramaComboBox.FormattingEnabled = true;
            this.vitesAramaComboBox.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.vitesAramaComboBox.Location = new System.Drawing.Point(12, 214);
            this.vitesAramaComboBox.Name = "vitesAramaComboBox";
            this.vitesAramaComboBox.Size = new System.Drawing.Size(132, 21);
            this.vitesAramaComboBox.TabIndex = 8;
            // 
            // minKmtextBox
            // 
            this.minKmtextBox.Location = new System.Drawing.Point(58, 241);
            this.minKmtextBox.Name = "minKmtextBox";
            this.minKmtextBox.Size = new System.Drawing.Size(60, 20);
            this.minKmtextBox.TabIndex = 9;
            // 
            // maxKmtextBox
            // 
            this.maxKmtextBox.Location = new System.Drawing.Point(58, 279);
            this.maxKmtextBox.Name = "maxKmtextBox";
            this.maxKmtextBox.Size = new System.Drawing.Size(60, 20);
            this.maxKmtextBox.TabIndex = 10;
            // 
            // renkAramacomboBox
            // 
            this.renkAramacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renkAramacomboBox.FormattingEnabled = true;
            this.renkAramacomboBox.Items.AddRange(new object[] {
            "Beyaz",
            "Gri",
            "Kırmızı",
            "Mavi",
            "Siyah",
            "Lacivert",
            "Sarı",
            "Yeşil",
            "Bordo",
            "Turuncu"});
            this.renkAramacomboBox.Location = new System.Drawing.Point(12, 312);
            this.renkAramacomboBox.Name = "renkAramacomboBox";
            this.renkAramacomboBox.Size = new System.Drawing.Size(132, 21);
            this.renkAramacomboBox.TabIndex = 11;
            // 
            // ilanAramacomboBox
            // 
            this.ilanAramacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilanAramacomboBox.FormattingEnabled = true;
            this.ilanAramacomboBox.Items.AddRange(new object[] {
            "Son 24 Saat",
            "Son 1 Hafta",
            "Son 1 Ay"});
            this.ilanAramacomboBox.Location = new System.Drawing.Point(12, 344);
            this.ilanAramacomboBox.Name = "ilanAramacomboBox";
            this.ilanAramacomboBox.Size = new System.Drawing.Size(132, 21);
            this.ilanAramacomboBox.TabIndex = 12;
            // 
            // Arama
            // 
            this.Arama.Location = new System.Drawing.Point(12, 371);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(132, 35);
            this.Arama.TabIndex = 13;
            this.Arama.Text = "Arama";
            this.Arama.UseVisualStyleBackColor = true;
            this.Arama.Click += new System.EventHandler(this.Arama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Min TL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Max TL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Min Km:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Max Km:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arama);
            this.Controls.Add(this.ilanAramacomboBox);
            this.Controls.Add(this.renkAramacomboBox);
            this.Controls.Add(this.maxKmtextBox);
            this.Controls.Add(this.minKmtextBox);
            this.Controls.Add(this.vitesAramaComboBox);
            this.Controls.Add(this.yakitAramacomboBox);
            this.Controls.Add(this.maxAramatextBox);
            this.Controls.Add(this.minAramatextBox);
            this.Controls.Add(this.sehirAramacomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Kayıt_Sil);
            this.Controls.Add(this.Kayıt_Ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kayıt_Ekle;
        private System.Windows.Forms.Button Kayıt_Sil;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox sehirAramacomboBox;
        private System.Windows.Forms.TextBox minAramatextBox;
        private System.Windows.Forms.TextBox maxAramatextBox;
        private System.Windows.Forms.ComboBox yakitAramacomboBox;
        private System.Windows.Forms.ComboBox vitesAramaComboBox;
        private System.Windows.Forms.TextBox minKmtextBox;
        private System.Windows.Forms.TextBox maxKmtextBox;
        private System.Windows.Forms.ComboBox renkAramacomboBox;
        private System.Windows.Forms.ComboBox ilanAramacomboBox;
        private System.Windows.Forms.Button Arama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

