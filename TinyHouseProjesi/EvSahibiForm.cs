using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
    public partial class EvSahibiForm : Form
    {
        private int kullaniciID;

        public EvSahibiForm(int id)
        {
            InitializeComponent();
            kullaniciID = id;
            IlanlariYukle();
        }

        private void EvSahibiForm_Load(object sender, EventArgs e)
        {
          
        }

        private void IlanlariYukle()
        {
            MessageBox.Show("İlanlar yükleniyor...");
            string connectionString = @"DATA SOURCE=localhost\SQLEXPRESS;INITIAL CATALOG=TinyHouseProject;INTEGRATED SECURITY=TRUE";

            string query = @"
        SELECT e.EvID, e.Baslik, e.GecelikFiyat, e.OdaSayisi, e.Il, e.Ilce, e.Adres, e.Aciklama, e.EvAktif, e.EklenmeTarihi,
               f.GörüntüBağlantısı
        FROM Evler e
        LEFT JOIN (
            SELECT EvID, MIN(GörüntüBağlantısı) as GörüntüBağlantısı
            FROM EvResimleri
            GROUP BY EvID
        ) f ON e.EvID = f.EvID
        WHERE e.KullaniciID = @kullaniciID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        da.Fill(dt);
                     

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Henüz bir ilanınız yok.");
                        }

                        dataGridViewIlanlar.DataSource = dt;
                        dataGridViewIlanlar.Columns["EvID"].Visible = false;
                        dataGridViewIlanlar.Columns["GörüntüBağlantısı"].HeaderText= "Görüntü Bağlantısı";

                        dataGridViewIlanlar.Columns["Baslik"].HeaderText = "İlan Başlığı";
                        dataGridViewIlanlar.Columns["GecelikFiyat"].HeaderText = "Gecelik Fiyat";
                        dataGridViewIlanlar.Columns["OdaSayisi"].HeaderText = "Oda Sayısı";
                        dataGridViewIlanlar.Columns["Il"].HeaderText = "İl";
                        dataGridViewIlanlar.Columns["Ilce"].HeaderText = "İlçe";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }



        private void btnIlanEkle_Click(object sender, EventArgs e)
        {
            IlanEkleForm ilanform = new IlanEkleForm(kullaniciID);
            ilanform.Show();
        }

        #region click events for other buttons
        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewIlanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilanı seçin.");
                return;
            }

            // Seçilen satırdan EvID'yi al
            int evID = Convert.ToInt32(dataGridViewIlanlar.SelectedRows[0].Cells["EvID"].Value);

            // Kullanıcıdan onay al
            DialogResult onay = MessageBox.Show("Bu ilanı silmek istediğinizden emin misiniz?", "İlan Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                string connectionString = @"DATA SOURCE=localhost\SQLEXPRESS;INITIAL CATALOG=TinyHouseProject;INTEGRATED SECURITY=TRUE";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string deleteResimlerQuery = "DELETE FROM EvResimleri WHERE EvID = @EvID";
                        SqlCommand cmdResim = new SqlCommand(deleteResimlerQuery, conn);
                        cmdResim.Parameters.AddWithValue("@EvID", evID);
                        cmdResim.ExecuteNonQuery();

                        string deleteIlanQuery = "DELETE FROM Evler WHERE EvID = @EvID";
                        SqlCommand cmd = new SqlCommand(deleteIlanQuery, conn);
                        cmd.Parameters.AddWithValue("@EvID", evID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("İlan başarıyla silindi.");

                        
                        IlanlariYukle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }


        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
           IlanlariYukle();
            MessageBox.Show("Rezervasyonlar henüz eklenmedi.");
            // Rezervasyonları yüklemek için gerekli kodlar buraya eklenecek.
            // Örneğin, rezervasyonları bir DataGridView'de göstermek için gerekli SQL sorgusu ve veri bağlama işlemleri yapılabilir.
        }

        private void btnRezervasyonOnayla_Click(object sender, EventArgs e)
        {
           
            IlanlariYukle();
            MessageBox.Show("Rezervasyon onaylama işlemi henüz eklenmedi.");
        }

        private void btnRezervasyonReddet_Click(object sender, EventArgs e)
        {      

            MessageBox.Show("Rezervasyon reddetme işlemi henüz eklenmedi.");
        }
        #endregion

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            IlanlariYukle();

        }
    }
}
