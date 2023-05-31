namespace HotelOtoSystem
{
    partial class FrmYeniMusteri
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
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            txtUcret = new TextBox();
            BtnKaydet = new Button();
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
            groupBox2 = new GroupBox();
            BtnOda105 = new Button();
            BtnOda106 = new Button();
            BtnOda107 = new Button();
            BtnOda108 = new Button();
            BtnOda103 = new Button();
            BtnOda102 = new Button();
            BtnOda104 = new Button();
            BtnOda101 = new Button();
            BtnBosOda = new Button();
            BtnDoluOda = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtUcret);
            groupBox1.Controls.Add(BtnKaydet);
            groupBox1.Controls.Add(DtpCikisTarihi);
            groupBox1.Controls.Add(DtpGirisTarihi);
            groupBox1.Controls.Add(MskTxtTelefon);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtKimlikNo);
            groupBox1.Controls.Add(TxtOdaNo);
            groupBox1.Controls.Add(txtSoyadi);
            groupBox1.Controls.Add(txtAdi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgiler";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(375, 408);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 39;
            label11.Text = "0";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 111);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 38;
            label10.Text = "Cinsiyet:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 192);
            comboBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay", "Bayan" });
            comboBox1.Location = new Point(142, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 31);
            comboBox1.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(91, 293);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 36;
            label9.Text = "Ücret:";
            // 
            // txtUcret
            // 
            txtUcret.BackColor = Color.FromArgb(255, 255, 192);
            txtUcret.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUcret.Location = new Point(142, 286);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(177, 31);
            txtUcret.TabIndex = 35;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(180, 408);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(111, 36);
            BtnKaydet.TabIndex = 34;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpCikisTarihi.Location = new Point(142, 362);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(250, 27);
            DtpCikisTarihi.TabIndex = 33;
            DtpCikisTarihi.ValueChanged += DtpCikisTarihi_ValueChanged;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpGirisTarihi.Location = new Point(142, 327);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(250, 27);
            DtpGirisTarihi.TabIndex = 32;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.BackColor = Color.FromArgb(255, 255, 192);
            MskTxtTelefon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            MskTxtTelefon.Location = new Point(142, 138);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(177, 31);
            MskTxtTelefon.TabIndex = 31;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(255, 255, 192);
            txtMail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtMail.Location = new Point(142, 175);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(177, 31);
            txtMail.TabIndex = 30;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.BackColor = Color.FromArgb(255, 255, 192);
            txtKimlikNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtKimlikNo.Location = new Point(142, 212);
            txtKimlikNo.MaxLength = 11;
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(177, 31);
            txtKimlikNo.TabIndex = 29;
            txtKimlikNo.TextChanged += txtKimlikNo_TextChanged;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.BackColor = Color.FromArgb(255, 255, 192);
            TxtOdaNo.Enabled = false;
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtOdaNo.Location = new Point(142, 249);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(177, 31);
            TxtOdaNo.TabIndex = 28;
            TxtOdaNo.TextChanged += TxtOdaNo_TextChanged;
            // 
            // txtSoyadi
            // 
            txtSoyadi.BackColor = Color.FromArgb(255, 255, 192);
            txtSoyadi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyadi.Location = new Point(142, 63);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(177, 31);
            txtSoyadi.TabIndex = 27;
            // 
            // txtAdi
            // 
            txtAdi.BackColor = Color.FromArgb(255, 255, 192);
            txtAdi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdi.Location = new Point(142, 26);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(177, 31);
            txtAdi.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 360);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 25;
            label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 327);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 24;
            label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 260);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 23;
            label6.Text = "Oda Numarası:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 223);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 22;
            label5.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 189);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 21;
            label4.Text = "Mail: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 149);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 20;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 74);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 19;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 37);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 18;
            label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnOda105);
            groupBox2.Controls.Add(BtnOda106);
            groupBox2.Controls.Add(BtnOda107);
            groupBox2.Controls.Add(BtnOda108);
            groupBox2.Controls.Add(BtnOda103);
            groupBox2.Controls.Add(BtnOda102);
            groupBox2.Controls.Add(BtnOda104);
            groupBox2.Controls.Add(BtnOda101);
            groupBox2.Location = new Point(413, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar";
            // 
            // BtnOda105
            // 
            BtnOda105.BackColor = Color.GreenYellow;
            BtnOda105.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda105.Location = new Point(18, 154);
            BtnOda105.Name = "BtnOda105";
            BtnOda105.Size = new Size(73, 47);
            BtnOda105.TabIndex = 7;
            BtnOda105.Text = "105";
            BtnOda105.UseVisualStyleBackColor = false;
            BtnOda105.Click += BtnOda105_Click;
            // 
            // BtnOda106
            // 
            BtnOda106.BackColor = Color.GreenYellow;
            BtnOda106.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda106.Location = new Point(125, 154);
            BtnOda106.Name = "BtnOda106";
            BtnOda106.Size = new Size(71, 47);
            BtnOda106.TabIndex = 6;
            BtnOda106.Text = "106";
            BtnOda106.UseVisualStyleBackColor = false;
            BtnOda106.Click += BtnOda106_Click;
            // 
            // BtnOda107
            // 
            BtnOda107.BackColor = Color.GreenYellow;
            BtnOda107.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda107.Location = new Point(18, 218);
            BtnOda107.Name = "BtnOda107";
            BtnOda107.Size = new Size(73, 47);
            BtnOda107.TabIndex = 5;
            BtnOda107.Text = "107";
            BtnOda107.UseVisualStyleBackColor = false;
            BtnOda107.Click += BtnOda107_Click;
            // 
            // BtnOda108
            // 
            BtnOda108.BackColor = Color.GreenYellow;
            BtnOda108.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda108.Location = new Point(125, 218);
            BtnOda108.Name = "BtnOda108";
            BtnOda108.Size = new Size(71, 47);
            BtnOda108.TabIndex = 4;
            BtnOda108.Text = "108";
            BtnOda108.UseVisualStyleBackColor = false;
            BtnOda108.Click += BtnOda108_Click;
            // 
            // BtnOda103
            // 
            BtnOda103.BackColor = Color.GreenYellow;
            BtnOda103.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda103.Location = new Point(18, 90);
            BtnOda103.Name = "BtnOda103";
            BtnOda103.Size = new Size(73, 47);
            BtnOda103.TabIndex = 3;
            BtnOda103.Text = "103";
            BtnOda103.UseVisualStyleBackColor = false;
            BtnOda103.Click += BtnOda103_Click;
            // 
            // BtnOda102
            // 
            BtnOda102.BackColor = Color.GreenYellow;
            BtnOda102.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda102.Location = new Point(125, 28);
            BtnOda102.Name = "BtnOda102";
            BtnOda102.Size = new Size(71, 47);
            BtnOda102.TabIndex = 2;
            BtnOda102.Text = "102";
            BtnOda102.UseVisualStyleBackColor = false;
            BtnOda102.Click += BtnOda102_Click;
            // 
            // BtnOda104
            // 
            BtnOda104.BackColor = Color.GreenYellow;
            BtnOda104.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda104.Location = new Point(125, 90);
            BtnOda104.Name = "BtnOda104";
            BtnOda104.Size = new Size(71, 47);
            BtnOda104.TabIndex = 1;
            BtnOda104.Text = "104";
            BtnOda104.UseVisualStyleBackColor = false;
            BtnOda104.Click += BtnOda104_Click;
            // 
            // BtnOda101
            // 
            BtnOda101.BackColor = Color.GreenYellow;
            BtnOda101.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda101.Location = new Point(18, 28);
            BtnOda101.Name = "BtnOda101";
            BtnOda101.Size = new Size(73, 47);
            BtnOda101.TabIndex = 0;
            BtnOda101.Text = "101";
            BtnOda101.UseVisualStyleBackColor = false;
            BtnOda101.Click += BtnOda101_Click;
            // 
            // BtnBosOda
            // 
            BtnBosOda.BackColor = Color.GreenYellow;
            BtnBosOda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBosOda.Location = new Point(469, 458);
            BtnBosOda.Name = "BtnBosOda";
            BtnBosOda.Size = new Size(73, 47);
            BtnBosOda.TabIndex = 8;
            BtnBosOda.Text = "Boş";
            BtnBosOda.UseVisualStyleBackColor = false;
            BtnBosOda.Click += button10_Click;
            // 
            // BtnDoluOda
            // 
            BtnDoluOda.BackColor = Color.Red;
            BtnDoluOda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDoluOda.Location = new Point(567, 458);
            BtnDoluOda.Name = "BtnDoluOda";
            BtnDoluOda.Size = new Size(71, 47);
            BtnDoluOda.TabIndex = 9;
            BtnDoluOda.Text = "Dolu";
            BtnDoluOda.UseVisualStyleBackColor = false;
            BtnDoluOda.Click += BtnDoluOda_Click;
            // 
            // FrmYeniMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 511);
            Controls.Add(BtnDoluOda);
            Controls.Add(groupBox2);
            Controls.Add(BtnBosOda);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmYeniMusteri";
            Text = "YeniMusteri Ekle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        

        #endregion

        private GroupBox groupBox1;
        private Button BtnKaydet;
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
        private GroupBox groupBox2;
        private Button BtnDoluOda;
        private Button BtnBosOda;
        private Button BtnOda105;
        private Button BtnOda106;
        private Button BtnOda107;
        private Button BtnOda108;
        private Button BtnOda103;
        private Button BtnOda102;
        private Button BtnOda104;
        private Button BtnOda101;
        private TextBox txtUcret;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private Label label11;
    }
}