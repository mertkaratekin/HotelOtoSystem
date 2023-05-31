namespace HotelOtoSystem
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "12345")
            {
                FrmAnaFromcs fr = new FrmAnaFromcs();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Sifre Hatalý!");
            }
        }

    }
}