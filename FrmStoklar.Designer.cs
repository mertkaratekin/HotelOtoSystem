namespace HotelOtoSystem
{
    partial class FrmStoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoklar));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            BtnKaydet = new Button();
            TxtAtistirmaliklar = new TextBox();
            TxtIcecekler = new TextBox();
            TxtGidalar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            BtnKaydet2 = new Button();
            TxtInternet = new TextBox();
            TxtSu = new TextBox();
            TxtElektrik = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(0, 299);
            listView1.Name = "listView1";
            listView1.Size = new Size(468, 211);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Gıdalar";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İçecekler";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Atıştırmalıklar";
            columnHeader3.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(BtnKaydet);
            groupBox1.Controls.Add(TxtAtistirmaliklar);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(TxtIcecekler);
            groupBox1.Controls.Add(TxtGidalar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 510);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mutfak";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(356, 251);
            label8.Name = "label8";
            label8.Size = new Size(78, 28);
            label8.TabIndex = 24;
            label8.Text = "Kaydet";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackgroundImage = (Image)resources.GetObject("BtnKaydet.BackgroundImage");
            BtnKaydet.BackgroundImageLayout = ImageLayout.Stretch;
            BtnKaydet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(358, 196);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(76, 52);
            BtnKaydet.TabIndex = 21;
            BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // TxtAtistirmaliklar
            // 
            TxtAtistirmaliklar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAtistirmaliklar.Location = new Point(194, 125);
            TxtAtistirmaliklar.Name = "TxtAtistirmaliklar";
            TxtAtistirmaliklar.Size = new Size(175, 30);
            TxtAtistirmaliklar.TabIndex = 20;
            // 
            // TxtIcecekler
            // 
            TxtIcecekler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtIcecekler.Location = new Point(194, 85);
            TxtIcecekler.Name = "TxtIcecekler";
            TxtIcecekler.Size = new Size(175, 30);
            TxtIcecekler.TabIndex = 19;
            // 
            // TxtGidalar
            // 
            TxtGidalar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtGidalar.Location = new Point(194, 46);
            TxtGidalar.Name = "TxtGidalar";
            TxtGidalar.Size = new Size(175, 30);
            TxtGidalar.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 123);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 17;
            label3.Text = "Atıştırmalıklar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 87);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 16;
            label2.Text = "İçecek Tutarı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 49);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 15;
            label1.Text = "Gıda Tutarı :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(BtnKaydet2);
            groupBox2.Controls.Add(TxtInternet);
            groupBox2.Controls.Add(TxtSu);
            groupBox2.Controls.Add(TxtElektrik);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(481, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 510);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Faturalar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(347, 249);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 25;
            label7.Text = "Kaydet";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(0, 299);
            listView2.Name = "listView2";
            listView2.Size = new Size(473, 211);
            listView2.TabIndex = 22;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Elektrik";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Su";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İnternet";
            columnHeader6.Width = 150;
            // 
            // BtnKaydet2
            // 
            BtnKaydet2.BackgroundImage = (Image)resources.GetObject("BtnKaydet2.BackgroundImage");
            BtnKaydet2.BackgroundImageLayout = ImageLayout.Stretch;
            BtnKaydet2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet2.Location = new Point(347, 194);
            BtnKaydet2.Name = "BtnKaydet2";
            BtnKaydet2.Size = new Size(78, 52);
            BtnKaydet2.TabIndex = 35;
            BtnKaydet2.UseVisualStyleBackColor = true;
            BtnKaydet2.Click += BtnKaydet2_Click;
            // 
            // TxtInternet
            // 
            TxtInternet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtInternet.Location = new Point(197, 125);
            TxtInternet.Name = "TxtInternet";
            TxtInternet.Size = new Size(175, 30);
            TxtInternet.TabIndex = 34;
            // 
            // TxtSu
            // 
            TxtSu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSu.Location = new Point(197, 85);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(175, 30);
            TxtSu.TabIndex = 33;
            // 
            // TxtElektrik
            // 
            TxtElektrik.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtElektrik.Location = new Point(197, 47);
            TxtElektrik.Name = "TxtElektrik";
            TxtElektrik.Size = new Size(175, 30);
            TxtElektrik.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(92, 123);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 31;
            label4.Text = "İnternet :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(145, 87);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 30;
            label5.Text = "Su :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(96, 49);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 29;
            label6.Text = "Elektrik :";
            // 
            // FrmStoklar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(954, 511);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStoklar";
            Text = "Stoklar & Giderler";
            Load += FrmStoklar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox1;
        private Button BtnKaydet;
        private TextBox TxtAtistirmaliklar;
        private TextBox TxtIcecekler;
        private TextBox TxtGidalar;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnKaydet2;
        private TextBox TxtInternet;
        private TextBox TxtSu;
        private TextBox TxtElektrik;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private PictureBox pictureBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private Label label7;
    }
}