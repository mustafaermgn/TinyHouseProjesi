using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TinyHouseProjesi
{
    public partial class Kayıt_Ekranı : Form
    {
        public Kayıt_Ekranı()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GİRİŞ_EKRANI girişform = new GİRİŞ_EKRANI();
            girişform.Show();
            this.Hide();
        }

        private void kayittamamlama_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=TinyHouseProject;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string ad = textBox2.Text;
                    string soyad = textBox3.Text;
                    string eposta = textBox4.Text;
                    string sifre = textBox5.Text;
                    string telefon = textBox6.Text;

                    string rol;
                    if (radioButtonMusteri.Checked)
                        rol = "Müşteri";
                    else if (radioButtonSatici.Checked)
                        rol = "Satıcı";
                    else
                    {
                        MessageBox.Show("Lütfen bir rol seçiniz.");
                        return;
                    }

                    string query = "INSERT INTO Kullanicilar (Ad, SoyAd, Eposta, Sifre, Telefon, Rol, HesapAktif) " +
                                   "VALUES (@Ad, @Soyad, @Eposta, @Sifre, @Telefon, @Rol, @HesapAktif)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Eposta", eposta);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);
                    cmd.Parameters.AddWithValue("@Telefon", telefon);
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.Parameters.AddWithValue("@HesapAktif", true);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

    }
}
