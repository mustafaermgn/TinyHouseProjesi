using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
    public partial class GİRİŞ_EKRANI : Form
    {
        public GİRİŞ_EKRANI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GİRİŞ_EKRANI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void giriş_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = SqlCon.Connect())
            {


                connection.Open();
                string queryForLogin = "SELECT * FROM Kullanicilar WHERE Eposta = @eposta AND Sifre = @sifre";
                using (SqlCommand cmd = new SqlCommand(queryForLogin, connection))
                {
                    cmd.Parameters.AddWithValue("@eposta", eposta.Text);
                    cmd.Parameters.AddWithValue("@sifre", sifre.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Giriş Başarılı!");
                            
                           
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("E-posta Veya Şifre Yanlış!");
                        }
                    }
                }
            }
        }

        private void kayit_Click(object sender, EventArgs e)
        {

            Kayıt_Ekranı kayıtForm = new Kayıt_Ekranı(); 
            kayıtForm.Show();                         
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ŞifremiUnuttum şifreform = new ŞifremiUnuttum();
            şifreform.Show();
        
        }

        private void eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void GİRİŞ_EKRANI_Load_1(object sender, EventArgs e)
        {

        }
    }
    }
    

                   