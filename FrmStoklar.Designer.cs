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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1 = new GroupBox();
            BtnKaydet = new Button();
            TxtAtistirmaliklar = new TextBox();
            TxtIcecekler = new TextBox();
            TxtGidalar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
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
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(0, 261);
            listView1.Name = "listView1";
            listView1.Size = new Size(401, 190);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Gıdalar";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İçecekler";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Atıştırmalıklar";
            columnHeader3.Width = 280;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnKaydet);
            groupBox1.Controls.Add(TxtAtistirmaliklar);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(TxtIcecekler);
            groupBox1.Controls.Add(TxtGidalar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-2, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 451);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mutfak";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(217, 183);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(142, 29);
            BtnKaydet.TabIndex = 21;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // TxtAtistirmaliklar
            // 
            TxtAtistirmaliklar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAtistirmaliklar.Location = new Point(184, 125);
            TxtAtistirmaliklar.Name = "TxtAtistirmaliklar";
            TxtAtistirmaliklar.Size = new Size(175, 30);
            TxtAtistirmaliklar.TabIndex = 20;
            // 
            // TxtIcecekler
            // 
            TxtIcecekler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtIcecekler.Location = new Point(184, 89);
            TxtIcecekler.Name = "TxtIcecekler";
            TxtIcecekler.Size = new Size(175, 30);
            TxtIcecekler.TabIndex = 19;
            // 
            // TxtGidalar
            // 
            TxtGidalar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtGidalar.Location = new Point(184, 49);
            TxtGidalar.Name = "TxtGidalar";
            TxtGidalar.Size = new Size(175, 30);
            TxtGidalar.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 128);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 17;
            label3.Text = "Atıştırmalıklar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 89);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 16;
            label2.Text = "İçecek Tutarı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 49);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 15;
            label1.Text = "Gıda Tutarı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(BtnKaydet2);
            groupBox2.Controls.Add(TxtInternet);
            groupBox2.Controls.Add(TxtSu);
            groupBox2.Controls.Add(TxtElektrik);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(405, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 451);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Faturalar";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(0, 261);
            listView2.Name = "listView2";
            listView2.Size = new Size(401, 190);
            listView2.TabIndex = 22;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Elektrik";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Su";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İnternet";
            columnHeader6.Width = 280;
            // 
            // BtnKaydet2
            // 
            BtnKaydet2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet2.Location = new Point(148, 181);
            BtnKaydet2.Name = "BtnKaydet2";
            BtnKaydet2.Size = new Size(142, 29);
            BtnKaydet2.TabIndex = 35;
            BtnKaydet2.Text = "Kaydet";
            BtnKaydet2.UseVisualStyleBackColor = true;
            BtnKaydet2.Click += BtnKaydet2_Click;
            // 
            // TxtInternet
            // 
            TxtInternet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtInternet.Location = new Point(115, 123);
            TxtInternet.Name = "TxtInternet";
            TxtInternet.Size = new Size(175, 30);
            TxtInternet.TabIndex = 34;
            // 
            // TxtSu
            // 
            TxtSu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSu.Location = new Point(115, 87);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(175, 30);
            TxtSu.TabIndex = 33;
            // 
            // TxtElektrik
            // 
            TxtElektrik.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtElektrik.Location = new Point(115, 49);
            TxtElektrik.Name = "TxtElektrik";
            TxtElektrik.Size = new Size(175, 30);
            TxtElektrik.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 126);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 31;
            label4.Text = "İnternet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(67, 87);
            label5.Name = "label5";
            label5.Size = new Size(33, 23);
            label5.TabIndex = 30;
            label5.Text = "Su:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 52);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 29;
            label6.Text = "Elektrik:";
            // 
            // FrmStoklar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(802, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStoklar";
            Text = "Stoklar & Giderler";
            Load += FrmStoklar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}