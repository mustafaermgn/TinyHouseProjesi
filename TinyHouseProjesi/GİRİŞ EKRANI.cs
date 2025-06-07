using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
    public partial class GİRİŞ_EKRANI : Form
    {
        public GİRİŞ_EKRANI()
        {
            InitializeComponent();
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
                try
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
                                string kullaniciAdi = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                                string rol = dr["Rol"].ToString(); 

                                MessageBox.Show("Giriş Başarılı! Hoşgeldiniz: " + kullaniciAdi, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();

                                if (rol == "Admin")
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.ShowDialog();
                                }
                                else if (rol == "EvSahibi") 
                                {
                                    int kullaniciID = Convert.ToInt32(dr["KullaniciID"]);
                                    EvSahibiForm evsahibi = new EvSahibiForm(kullaniciID); 
                                    evsahibi.Show();
                                }
                                else if (rol == "Kiracı")
                                {
                                    int kullaniciID = Convert.ToInt32(dr["KullaniciID"]);
                                    KiraciForm kiraciForm = new KiraciForm(kullaniciID);
                                    kiraciForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Tanımsız rol: " + rol);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hatalı e-posta veya şifre.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ŞifremiUnuttum sifreForm = new ŞifremiUnuttum();
            sifreForm.Show();
        }

        
        private void GİRİŞ_EKRANI_Load(object sender, EventArgs e) { }
        private void eposta_TextChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
