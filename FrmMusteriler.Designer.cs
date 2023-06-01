namespace HotelOtoSystem
{
    partial class FrmMusteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            BtnVerileriGoster = new Button();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnAra = new Button();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            txtUcret = new TextBox();
            DtpCikisTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            MskTxtTelefon = new MaskedTextBox();
            txtMail = new TextBox();
            txtKimlikNo = new TextBox();
            TxtOdaNo = new TextBox();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            BtnTemizle = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(0, 324);
            listView1.Name = "listView1";
            listView1.Size = new Size(797, 137);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "OdaNo";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "G.Tarih";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Ç.Tarih";
            // 
            // BtnVerileriGoster
            // 
            BtnVerileriGoster.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerileriGoster.Location = new Point(608, 10);
            BtnVerileriGoster.Name = "BtnVerileriGoster";
            BtnVerileriGoster.Size = new Size(155, 44);
            BtnVerileriGoster.TabIndex = 1;
            BtnVerileriGoster.Text = "Verileri Göster";
            BtnVerileriGoster.UseVisualStyleBackColor = true;
            BtnVerileriGoster.Click += button1_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(608, 60);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(155, 44);
            BtnGuncelle.TabIndex = 2;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSil.Location = new Point(608, 114);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(155, 39);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnAra
            // 
            BtnAra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAra.Location = new Point(608, 207);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(155, 41);
            BtnAra.TabIndex = 4;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 95);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 58;
            label10.Text = "Cinsiyet:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 192);
            comboBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay", "Bayan" });
            comboBox1.Location = new Point(69, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 31);
            comboBox1.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(306, 58);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 56;
            label9.Text = "Ücret:";
            // 
            // txtUcret
            // 
            txtUcret.BackColor = Color.FromArgb(255, 255, 192);
            txtUcret.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUcret.Location = new Point(359, 51);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(177, 31);
            txtUcret.TabIndex = 55;
            txtUcret.TextChanged += txtUcret_TextChanged;
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpCikisTarihi.Location = new Point(338, 122);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(250, 27);
            DtpCikisTarihi.TabIndex = 54;
            DtpCikisTarihi.ValueChanged += DtpCikisTarihi_ValueChanged;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpGirisTarihi.Location = new Point(338, 90);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(250, 27);
            DtpGirisTarihi.TabIndex = 53;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.BackColor = Color.FromArgb(255, 255, 192);
            MskTxtTelefon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            MskTxtTelefon.Location = new Point(69, 122);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(177, 31);
            MskTxtTelefon.TabIndex = 52;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(255, 255, 192);
            txtMail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtMail.Location = new Point(69, 159);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(177, 31);
            txtMail.TabIndex = 51;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.BackColor = Color.FromArgb(255, 255, 192);
            txtKimlikNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtKimlikNo.Location = new Point(69, 196);
            txtKimlikNo.MaxLength = 11;
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(177, 31);
            txtKimlikNo.TabIndex = 50;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.BackColor = Color.FromArgb(255, 255, 192);
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtOdaNo.Location = new Point(359, 15);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(177, 31);
            TxtOdaNo.TabIndex = 49;
            // 
            // txtSoyadi
            // 
            txtSoyadi.BackColor = Color.FromArgb(255, 255, 192);
            txtSoyadi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyadi.Location = new Point(69, 47);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(177, 31);
            txtSoyadi.TabIndex = 48;
            // 
            // txtAdi
            // 
            txtAdi.BackColor = Color.FromArgb(255, 255, 192);
            txtAdi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdi.Location = new Point(69, 10);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(177, 31);
            txtAdi.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(252, 122);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 46;
            label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 93);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 45;
            label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(248, 21);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 44;
            label6.Text = "Oda Numarası:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-31, 207);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 43;
            label5.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 173);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 42;
            label4.Text = "Mail: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 133);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 41;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 40;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 39;
            label1.Text = "Adı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(525, 270);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 60;
            label11.Text = "İsim: ";
            label11.Click += label11_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(574, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 31);
            textBox1.TabIndex = 59;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTemizle.Location = new Point(608, 160);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(155, 41);
            BtnTemizle.TabIndex = 61;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 460);
            Controls.Add(BtnTemizle);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(txtUcret);
            Controls.Add(DtpCikisTarihi);
            Controls.Add(DtpGirisTarihi);
            Controls.Add(MskTxtTelefon);
            Controls.Add(txtMail);
            Controls.Add(txtKimlikNo);
            Controls.Add(TxtOdaNo);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAra);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnVerileriGoster);
            Controls.Add(listView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMusteriler";
            Text = " Müşteri Bilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button BtnVerileriGoster;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnAra;
        private Label label10;
        private ComboBox comboBox1;
        private Label label9;
        private TextBox txtUcret;
        private DateTimePicker DtpCikisTarihi;
        private DateTimePicker DtpGirisTarihi;
        private MaskedTextBox MskTxtTelefon;
        private TextBox txtMail;
        private TextBox txtKimlikNo;
        private TextBox TxtOdaNo;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private TextBox textBox1;
        private Button BtnTemizle;
    }
}