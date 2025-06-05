using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace TinyHouseProjesi
{
    public partial class ŞifremiUnuttum : Form
    {
        public ŞifremiUnuttum()
        {
            InitializeComponent();
        }

        private void ŞifremiUnuttum_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void gönderme_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = textBox1.Text.Trim();
                string soyad = textBox2.Text.Trim();
                string eposta = textBox3.Text.Trim(); 

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(eposta))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                string retrievedPassword = string.Empty;
                 string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TinyHouseProject";

               
                string query = "SELECT Parola FROM Kullanicilar WHERE Ad = @Ad AND Soyad = @Soyad AND Eposta = @Eposta"; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Eposta", eposta); 

                    connection.Open();
                    object result = command.ExecuteScalar(); 

                    if (result != null)
                    {
                        retrievedPassword = result.ToString(); 
                    }
                    else
                    {
                        MessageBox.Show("Girilen bilgilere sahip kullanıcı bulunamadı.");
                        return; 
                    }
                }

         
                if (string.IsNullOrEmpty(retrievedPassword))
                {
                    MessageBox.Show("Şifre veritabanından alınamadı. Lütfen bilgilerinizi kontrol edin.");
                    return;
                }

               
                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("TinyHouseProject55@gmail.com");
                mesaj.To.Add(eposta);
                mesaj.Subject = "Şifreniz Talebiniz Üzerine Gönderilmiştir";
               
                mesaj.Body = $"Merhaba {ad} {soyad},\n\nTalebiniz üzerine şifreniz: **{retrievedPassword}**\n\nGüvenliğiniz için lütfen bu şifreyi kimseyle paylaşmayın ve isterseniz değiştirin.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); 
            
                smtp.Credentials = new NetworkCredential("TinyHouseProject55@gmail.com", "sdplywnmyequcnsh");
                smtp.EnableSsl = true;

                smtp.Send(mesaj); 

                MessageBox.Show("Şifreniz e-posta adresinize gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilemedi: " + ex.Message + "\n\nDetay: " + ex.ToString());
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            GİRİŞ_EKRANI girişform = new GİRİŞ_EKRANI();
            girişform.Show();
            this.Hide();
        }
    }
}