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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
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
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(-1, 369);
            listView1.Name = "listView1";
            listView1.Size = new Size(956, 142);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            columnHeader7.Width = 85;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "OdaNo";
            columnHeader8.Width = 85;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            columnHeader9.Width = 85;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "G.Tarih";
            columnHeader10.Width = 110;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Ç.Tarih";
            columnHeader11.Width = 110;
            // 
            // BtnVerileriGoster
            // 
            BtnVerileriGoster.BackColor = Color.White;
            BtnVerileriGoster.BackgroundImage = (Image)resources.GetObject("BtnVerileriGoster.BackgroundImage");
            BtnVerileriGoster.BackgroundImageLayout = ImageLayout.Stretch;
            BtnVerileriGoster.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerileriGoster.ForeColor = Color.Black;
            BtnVerileriGoster.Location = new Point(787, 296);
            BtnVerileriGoster.Name = "BtnVerileriGoster";
            BtnVerileriGoster.Size = new Size(155, 67);
            BtnVerileriGoster.TabIndex = 1;
            BtnVerileriGoster.UseVisualStyleBackColor = false;
            BtnVerileriGoster.Click += button1_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackgroundImage = (Image)resources.GetObject("BtnGuncelle.BackgroundImage");
            BtnGuncelle.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGuncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(787, 1);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(155, 66);
            BtnGuncelle.TabIndex = 2;
            BtnGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackgroundImage = (Image)resources.GetObject("BtnSil.BackgroundImage");
            BtnSil.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSil.ImageAlign = ContentAlignment.MiddleRight;
            BtnSil.Location = new Point(787, 73);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(155, 67);
            BtnSil.TabIndex = 3;
            BtnSil.TextAlign = ContentAlignment.MiddleLeft;
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnAra
            // 
            BtnAra.BackgroundImage = (Image)resources.GetObject("BtnAra.BackgroundImage");
            BtnAra.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAra.Location = new Point(787, 223);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(155, 67);
            BtnAra.TabIndex = 4;
            BtnAra.TextAlign = ContentAlignment.TopCenter;
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(-1, 86);
            label10.Name = "label10";
            label10.Size = new Size(94, 28);
            label10.TabIndex = 58;
            label10.Text = "Cinsiyet :";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay", "Bayan" });
            comboBox1.Location = new Point(99, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 31);
            comboBox1.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(319, 46);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 56;
            label9.Text = "Ücret :";
            // 
            // txtUcret
            // 
            txtUcret.BackColor = Color.White;
            txtUcret.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUcret.Location = new Point(396, 51);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(177, 31);
            txtUcret.TabIndex = 55;
            txtUcret.TextChanged += txtUcret_TextChanged;
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpCikisTarihi.Location = new Point(396, 123);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(250, 27);
            DtpCikisTarihi.TabIndex = 54;
            DtpCikisTarihi.ValueChanged += DtpCikisTarihi_ValueChanged;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpGirisTarihi.Location = new Point(396, 88);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(250, 27);
            DtpGirisTarihi.TabIndex = 53;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.BackColor = Color.White;
            MskTxtTelefon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            MskTxtTelefon.Location = new Point(99, 124);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(177, 31);
            MskTxtTelefon.TabIndex = 52;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtMail.Location = new Point(99, 161);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(177, 31);
            txtMail.TabIndex = 51;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.BackColor = Color.White;
            txtKimlikNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtKimlikNo.Location = new Point(99, 198);
            txtKimlikNo.MaxLength = 11;
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(177, 31);
            txtKimlikNo.TabIndex = 50;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.BackColor = Color.White;
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtOdaNo.Location = new Point(396, 12);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(177, 31);
            TxtOdaNo.TabIndex = 49;
            // 
            // txtSoyadi
            // 
            txtSoyadi.BackColor = Color.White;
            txtSoyadi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyadi.Location = new Point(99, 49);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(177, 31);
            txtSoyadi.TabIndex = 48;
            // 
            // txtAdi
            // 
            txtAdi.BackColor = Color.White;
            txtAdi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdi.Location = new Point(99, 12);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(177, 31);
            txtAdi.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(290, 121);
            label8.Name = "label8";
            label8.Size = new Size(100, 28);
            label8.TabIndex = 46;
            label8.Text = "Çıkış Tar. :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(292, 85);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 45;
            label7.Text = "Giriş Tar. :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(297, 12);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 44;
            label6.Text = "Oda No :";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 195);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 43;
            label5.Text = "TC :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 158);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 42;
            label4.Text = "Mail : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 124);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 41;
            label3.Text = "Telefon :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 49);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 40;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 28);
            label1.TabIndex = 39;
            label1.Text = "Adı :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(463, 238);
            label11.Name = "label11";
            label11.Size = new Size(61, 28);
            label11.TabIndex = 60;
            label11.Text = "İsim :";
            label11.Click += label11_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(530, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 31);
            textBox1.TabIndex = 59;
            // 
            // BtnTemizle
            // 
            BtnTemizle.BackgroundImage = (Image)resources.GetObject("BtnTemizle.BackgroundImage");
            BtnTemizle.BackgroundImageLayout = ImageLayout.Zoom;
            BtnTemizle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTemizle.Location = new Point(787, 150);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(155, 67);
            BtnTemizle.TabIndex = 61;
            BtnTemizle.UseVisualStyleBackColor = true;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(735, 90);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(46, 28);
            label16.TabIndex = 69;
            label16.Text = "Sil :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(725, 238);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(56, 28);
            label17.TabIndex = 68;
            label17.Text = "Ara :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(686, 169);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.No;
            label18.Size = new Size(95, 28);
            label18.TabIndex = 67;
            label18.Text = "Temizle :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(679, 20);
            label19.Name = "label19";
            label19.Size = new Size(105, 28);
            label19.TabIndex = 66;
            label19.Text = "Guncelle :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(519, 306);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(262, 28);
            label12.TabIndex = 70;
            label12.Text = "Müşteri Bilgilerini Göster :";
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(954, 511);
            Controls.Add(label12);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
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
            Load += FrmMusteriler_Load;
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
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label12;
    }
}