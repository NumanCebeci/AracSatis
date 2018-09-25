namespace ProLab2_4
{
    partial class AracSistemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.markaCombo = new System.Windows.Forms.ComboBox();
            this.modelCombo = new System.Windows.Forms.ComboBox();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.yakitCombo = new System.Windows.Forms.ComboBox();
            this.vitesCombo = new System.Windows.Forms.ComboBox();
            this.renkCombo = new System.Windows.Forms.ComboBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sehirCombo = new System.Windows.Forms.ComboBox();
            this.AracDataGridView = new System.Windows.Forms.DataGridView();
            this.guncelleButon = new System.Windows.Forms.Button();
            this.ilanTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AracDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yakıt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Renk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "İlan Adı:";
            // 
            // markaCombo
            // 
            this.markaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markaCombo.FormattingEnabled = true;
            this.markaCombo.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Mercedes-Benz",
            "Volkswagen"});
            this.markaCombo.Location = new System.Drawing.Point(70, 10);
            this.markaCombo.Name = "markaCombo";
            this.markaCombo.Size = new System.Drawing.Size(121, 21);
            this.markaCombo.TabIndex = 8;
            this.markaCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modelCombo
            // 
            this.modelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCombo.FormattingEnabled = true;
            this.modelCombo.Location = new System.Drawing.Point(70, 43);
            this.modelCombo.Name = "modelCombo";
            this.modelCombo.Size = new System.Drawing.Size(121, 21);
            this.modelCombo.TabIndex = 9;
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(70, 171);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(121, 20);
            this.kmTextBox.TabIndex = 10;
            // 
            // yakitCombo
            // 
            this.yakitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yakitCombo.FormattingEnabled = true;
            this.yakitCombo.Items.AddRange(new object[] {
            "Benzin ",
            "Dizel",
            "Lpg&Benzin"});
            this.yakitCombo.Location = new System.Drawing.Point(70, 111);
            this.yakitCombo.Name = "yakitCombo";
            this.yakitCombo.Size = new System.Drawing.Size(121, 21);
            this.yakitCombo.TabIndex = 11;
            // 
            // vitesCombo
            // 
            this.vitesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vitesCombo.FormattingEnabled = true;
            this.vitesCombo.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.vitesCombo.Location = new System.Drawing.Point(70, 78);
            this.vitesCombo.Name = "vitesCombo";
            this.vitesCombo.Size = new System.Drawing.Size(121, 21);
            this.vitesCombo.TabIndex = 12;
            // 
            // renkCombo
            // 
            this.renkCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renkCombo.FormattingEnabled = true;
            this.renkCombo.Items.AddRange(new object[] {
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
            this.renkCombo.Location = new System.Drawing.Point(70, 141);
            this.renkCombo.Name = "renkCombo";
            this.renkCombo.Size = new System.Drawing.Size(121, 21);
            this.renkCombo.TabIndex = 13;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.Location = new System.Drawing.Point(70, 202);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(121, 20);
            this.fiyatTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Şehir";
            // 
            // sehirCombo
            // 
            this.sehirCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sehirCombo.FormattingEnabled = true;
            this.sehirCombo.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Bursa",
            "Eskişehir",
            "İstanbul",
            "Kocaeli",
            "Samsun",
            "Trabzon"});
            this.sehirCombo.Location = new System.Drawing.Point(70, 232);
            this.sehirCombo.Name = "sehirCombo";
            this.sehirCombo.Size = new System.Drawing.Size(121, 21);
            this.sehirCombo.TabIndex = 18;
            // 
            // AracDataGridView
            // 
            this.AracDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AracDataGridView.Location = new System.Drawing.Point(226, 10);
            this.AracDataGridView.Name = "AracDataGridView";
            this.AracDataGridView.Size = new System.Drawing.Size(652, 388);
            this.AracDataGridView.TabIndex = 19;
            // 
            // guncelleButon
            // 
            this.guncelleButon.Location = new System.Drawing.Point(104, 279);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(87, 23);
            this.guncelleButon.TabIndex = 20;
            this.guncelleButon.Text = "Güncelle";
            this.guncelleButon.UseVisualStyleBackColor = true;
            this.guncelleButon.Click += new System.EventHandler(this.guncelleButon_Click_1);
            // 
            // ilanTextBox
            // 
            this.ilanTextBox.Location = new System.Drawing.Point(70, 319);
            this.ilanTextBox.Multiline = true;
            this.ilanTextBox.Name = "ilanTextBox";
            this.ilanTextBox.Size = new System.Drawing.Size(121, 79);
            this.ilanTextBox.TabIndex = 21;
            // 
            // AracSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 410);
            this.Controls.Add(this.ilanTextBox);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.AracDataGridView);
            this.Controls.Add(this.sehirCombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(this.renkCombo);
            this.Controls.Add(this.vitesCombo);
            this.Controls.Add(this.yakitCombo);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.modelCombo);
            this.Controls.Add(this.markaCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AracSistemi";
            this.Text = "AracSistemi";
            this.Load += new System.EventHandler(this.AracSistemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AracDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView AracDataGridView;
        private System.Windows.Forms.Button guncelleButon;
        public System.Windows.Forms.TextBox ilanTextBox;
        public System.Windows.Forms.TextBox fiyatTextBox;
        public System.Windows.Forms.TextBox kmTextBox;
        public System.Windows.Forms.ComboBox sehirCombo;
        public System.Windows.Forms.ComboBox markaCombo;
        public System.Windows.Forms.ComboBox modelCombo;
        public System.Windows.Forms.ComboBox yakitCombo;
        public System.Windows.Forms.ComboBox vitesCombo;
        public System.Windows.Forms.ComboBox renkCombo;
    }
}