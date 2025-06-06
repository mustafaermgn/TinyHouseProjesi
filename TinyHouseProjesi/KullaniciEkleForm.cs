using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
    public partial class KullaniciEkleForm : Form
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=TinyHouseProject;Trusted_Connection=True;";

        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
           
            cmbRol.Items.Add("EvSahibi");
            cmbRol.Items.Add("Kiraci");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Kullanicilar (Ad, SoyAd, Eposta, Sifre, Rol, HesapAktif) VALUES (@Ad, @SoyAd, @Eposta, @Sifre, @Rol, 1)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@SoyAd", txtSoyAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@Eposta", txtEposta.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Rol", cmbRol.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı eklendi.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
