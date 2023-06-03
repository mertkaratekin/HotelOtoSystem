namespace HotelOtoSystem
{
    partial class FrmAdminGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            l = new Label();
            label2 = new Label();
            TxtKullaniciAdi = new TextBox();
            TxtSifre = new TextBox();
            BtnGirisYap = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l.Location = new Point(12, 218);
            l.Name = "l";
            l.Size = new Size(140, 28);
            l.TabIndex = 0;
            l.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 280);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre : ";
            label2.Click += label1_Click;
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.BackColor = Color.FromArgb(255, 255, 192);
            TxtKullaniciAdi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtKullaniciAdi.Location = new Point(158, 218);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(166, 30);
            TxtKullaniciAdi.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = Color.FromArgb(255, 255, 192);
            TxtSifre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSifre.Location = new Point(158, 280);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(166, 30);
            TxtSifre.TabIndex = 3;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGirisYap.Location = new Point(125, 336);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(158, 29);
            BtnGirisYap.TabIndex = 4;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(373, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 345);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(358, 41);
            label1.TabIndex = 6;
            label1.Text = "Otel Otomasyon Sistemi";
            label1.Click += label1_Click_1;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Aqua;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(l);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = " ";
            Load += FrmAdminGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l;
        private Label label2;
        private TextBox TxtKullaniciAdi;
        private TextBox TxtSifre;
        private Button BtnGirisYap;
        private PictureBox pictureBox1;
        private Label label1;
    }
}