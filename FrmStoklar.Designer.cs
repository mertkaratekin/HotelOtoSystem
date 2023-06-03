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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtGidalar = new TextBox();
            TxtIcecekler = new TextBox();
            TxtAtistirmaliklar = new TextBox();
            BtnKaydet = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 49);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 0;
            label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 89);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "İçecek Tutarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 128);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 2;
            label3.Text = "Atıştırmalıklar:";
            // 
            // TxtGidalar
            // 
            TxtGidalar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtGidalar.Location = new Point(189, 51);
            TxtGidalar.Name = "TxtGidalar";
            TxtGidalar.Size = new Size(175, 30);
            TxtGidalar.TabIndex = 3;
            // 
            // TxtIcecekler
            // 
            TxtIcecekler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtIcecekler.Location = new Point(189, 89);
            TxtIcecekler.Name = "TxtIcecekler";
            TxtIcecekler.Size = new Size(175, 30);
            TxtIcecekler.TabIndex = 4;
            // 
            // TxtAtistirmaliklar
            // 
            TxtAtistirmaliklar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAtistirmaliklar.Location = new Point(189, 125);
            TxtAtistirmaliklar.Name = "TxtAtistirmaliklar";
            TxtAtistirmaliklar.Size = new Size(175, 30);
            TxtAtistirmaliklar.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(222, 183);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(142, 29);
            BtnKaydet.TabIndex = 6;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(-1, 260);
            listView1.Name = "listView1";
            listView1.Size = new Size(801, 190);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Gıdalar";
            columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İçecekler";
            columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Atıştırmalıklar";
            columnHeader3.Width = 280;
            // 
            // FrmStoklar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(BtnKaydet);
            Controls.Add(TxtAtistirmaliklar);
            Controls.Add(TxtIcecekler);
            Controls.Add(TxtGidalar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStoklar";
            Text = "FrmStoklar";
            Load += FrmStoklar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtGidalar;
        private TextBox TxtIcecekler;
        private TextBox TxtAtistirmaliklar;
        private Button BtnKaydet;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}