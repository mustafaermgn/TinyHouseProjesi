using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
    public partial class IlanEkleForm : Form
    {
       
        private string connectionString = @"DATA SOURCE=localhost\SQLEXPRESS;INITIAL CATALOG=TinyHouseProject;INTEGRATED SECURITY=TRUE";

       
        private List<string> secilenFotograflarListesi = new List<string>();

        public IlanEkleForm()
        {
            InitializeComponent();
        }

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                secilenFotograflarListesi.Clear();
                secilenFotograflarListesi.AddRange(ofd.FileNames);

                
                lstFotograflar.Items.Clear();
                foreach (string dosyaYolu in secilenFotograflarListesi)
                {
                    lstFotograflar.Items.Add(System.IO.Path.GetFileName(dosyaYolu));
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtIlanBasligi.Text) ||
                string.IsNullOrWhiteSpace(txtIl.Text) ||
                string.IsNullOrWhiteSpace(txtIlce.Text) ||
                string.IsNullOrWhiteSpace(txtAdres.Text) ||
                string.IsNullOrWhiteSpace(txtOdaSayisi.Text) ||
                string.IsNullOrWhiteSpace(txtGecelikFiyat.Text))
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string evEkleQuery = @"
                    INSERT INTO Evler (kullaniciID, Baslik, Adres, Il, Ilce, OdaSayisi, GecelikFiyat, EvAktif, EklenmeTarihi, Aciklama)
                    VALUES (@kullaniciID, @Baslik, @Adres, @Il, @Ilce, @OdaSayisi, @GecelikFiyat, @EvAktif, @EklenmeTarihi, @Aciklama);
                    SELECT SCOPE_IDENTITY();
                ";

                SqlCommand cmd = new SqlCommand(evEkleQuery, connection);
                cmd.Parameters.AddWithValue("@kullaniciID", 21 ); 
                cmd.Parameters.AddWithValue("@Baslik", txtIlanBasligi.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@Il", txtIl.Text);
                cmd.Parameters.AddWithValue("@Ilce", txtIlce.Text);
                cmd.Parameters.AddWithValue("@OdaSayisi", Convert.ToInt32(txtOdaSayisi.Text));
                cmd.Parameters.AddWithValue("@GecelikFiyat", Convert.ToDecimal(txtGecelikFiyat.Text));
                cmd.Parameters.AddWithValue("@EvAktif", true);
                cmd.Parameters.AddWithValue("@EklenmeTarihi", DateTime.Now);
                cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text ?? "");

                try
                {
                    connection.Open();
                    int yeniEvID = Convert.ToInt32(cmd.ExecuteScalar());

                    bool isFirst = true;

                    foreach (string fotoPath in secilenFotograflarListesi)
                    {
                        
                        string sqlFoto = @"
                            INSERT INTO EvResimleri (EvID, GörüntüBağlantısı, IsMain)
                            VALUES (@EvID, @GörüntüBağlantısı, @IsMain);
                        ";

                        SqlCommand fotoCmd = new SqlCommand(sqlFoto, connection);
                        fotoCmd.Parameters.AddWithValue("@EvID", yeniEvID);
                        fotoCmd.Parameters.AddWithValue("@GörüntüBağlantısı", fotoPath);
                        fotoCmd.Parameters.AddWithValue("@IsMain", isFirst);
                        fotoCmd.ExecuteNonQuery();

                        isFirst = false;
                    }

                    MessageBox.Show("İlan ve fotoğraflar başarıyla kaydedildi!");
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void Temizle()
        {
            txtIlanBasligi.Clear();
            txtIl.Clear();
            txtIlce.Clear();
            txtAdres.Clear();
            txtOdaSayisi.Clear();
            txtGecelikFiyat.Clear();
            txtAciklama.Clear();
            lstFotograflar.Items.Clear();
            secilenFotograflarListesi.Clear();
        }
    }
}
    