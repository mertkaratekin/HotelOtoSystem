﻿namespace HotelOtoSystem
{
    partial class FrmGelirGider
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
            LblKasaToplam = new Label();
            label3 = new Label();
            label4 = new Label();
            LblPersonelMaas = new Label();
            LblAlinanUrunler = new Label();
            label7 = new Label();
            LblFaturalar = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(211, 24);
            label1.TabIndex = 0;
            label1.Text = "Kasadaki Toplam Tutar: ";
            // 
            // LblKasaToplam
            // 
            LblKasaToplam.AutoSize = true;
            LblKasaToplam.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblKasaToplam.Location = new Point(260, 24);
            LblKasaToplam.Name = "LblKasaToplam";
            LblKasaToplam.Size = new Size(30, 24);
            LblKasaToplam.TabIndex = 1;
            LblKasaToplam.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 68);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 2;
            label3.Text = "Personel Maaşları:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 111);
            label4.Name = "label4";
            label4.Size = new Size(209, 24);
            label4.TabIndex = 3;
            label4.Text = "Alınan Ürünlerin Tutarı:";
            // 
            // LblPersonelMaas
            // 
            LblPersonelMaas.AutoSize = true;
            LblPersonelMaas.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPersonelMaas.Location = new Point(260, 68);
            LblPersonelMaas.Name = "LblPersonelMaas";
            LblPersonelMaas.Size = new Size(30, 24);
            LblPersonelMaas.TabIndex = 4;
            LblPersonelMaas.Text = "00";
            // 
            // LblAlinanUrunler
            // 
            LblAlinanUrunler.AutoSize = true;
            LblAlinanUrunler.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAlinanUrunler.Location = new Point(260, 111);
            LblAlinanUrunler.Name = "LblAlinanUrunler";
            LblAlinanUrunler.Size = new Size(30, 24);
            LblAlinanUrunler.TabIndex = 5;
            LblAlinanUrunler.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(109, 156);
            label7.Name = "label7";
            label7.Size = new Size(147, 24);
            label7.TabIndex = 6;
            label7.Text = "Fatura Giderleri:";
            // 
            // LblFaturalar
            // 
            LblFaturalar.AutoSize = true;
            LblFaturalar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFaturalar.Location = new Point(260, 156);
            LblFaturalar.Name = "LblFaturalar";
            LblFaturalar.Size = new Size(30, 24);
            LblFaturalar.TabIndex = 7;
            LblFaturalar.Text = "00";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(497, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 28);
            textBox1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(351, 24);
            label9.Name = "label9";
            label9.Size = new Size(140, 24);
            label9.TabIndex = 9;
            label9.Text = "Personel Sayısı:";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(549, 175);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 10;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 259);
            label10.Name = "label10";
            label10.Size = new Size(66, 24);
            label10.TabIndex = 11;
            label10.Text = "Sonuç:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(12, 207);
            label11.Name = "label11";
            label11.Size = new Size(706, 24);
            label11.TabIndex = 12;
            label11.Text = "--------------------------------------------------------------------------------------------------------------------";
            // 
            // FrmGelirGider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(LblFaturalar);
            Controls.Add(label7);
            Controls.Add(LblAlinanUrunler);
            Controls.Add(LblPersonelMaas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LblKasaToplam);
            Controls.Add(label1);
            Name = "FrmGelirGider";
            Text = "FrmGelirGider";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblKasaToplam;
        private Label label3;
        private Label label4;
        private Label LblPersonelMaas;
        private Label LblAlinanUrunler;
        private Label label7;
        private Label LblFaturalar;
        private TextBox textBox1;
        private Label label9;
        private Button button1;
        private Label label10;
        private Label label11;
    }
}