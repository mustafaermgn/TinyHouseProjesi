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
           
            MessageBox.Show("Rezervasyon onaylama işlemi henüz eklenmedi.");
        }

        private void btnRezervasyonReddet_Click(object sender, EventArgs e)
        {      

            MessageBox.Show("Rezervasyon reddetme işlemi henüz eklenmedi.");
        }
      

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            IlanlariYukle();

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            dataGridViewIlanlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewIlanlar.MultiSelect = false;

            if (dataGridViewIlanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ilanı seçin.");
                return;
            }
            grp_guncelle.Visible = true;
            
        }

        private void dataGridViewIlanlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIlanlar.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewIlanlar.SelectedRows[0];
                tb_baslik.Text = row.Cells["Baslik"].Value.ToString();
                tb_aciklama.Text = row.Cells["Aciklama"].Value.ToString();
                tb_fiyat.Text = row.Cells["GecelikFiyat"].Value.ToString();
                tb_il.Text = row.Cells["Il"].Value.ToString();
                tb_ilce.Text = row.Cells["Ilce"].Value.ToString();
                tb_adres.Text = row.Cells["Adres"].Value.ToString();
                tb_odaSayisi.Text = row.Cells["OdaSayisi"].Value.ToString();
                cb_aktif.Checked = Convert.ToBoolean(row.Cells["EvAktif"].Value);

            }
        }


        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void güncelleOnay_Click(object sender, EventArgs e)
        {
            if (dataGridViewIlanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ilanı seçin.");
                return;
            }

            int evID = Convert.ToInt32(dataGridViewIlanlar.SelectedRows[0].Cells["EvID"].Value);
            string baslik = tb_baslik.Text.Trim();
            string aciklama = tb_aciklama.Text.Trim();
            string il = tb_il.Text.Trim();
            string ilce = tb_ilce.Text.Trim();
            string adres = tb_adres.Text.Trim();
            string odaSayisiText = tb_odaSayisi.Text.Trim();
            string fiyatText = tb_fiyat.Text.Trim();
            bool evAktif = cb_aktif.Checked;

            if (!decimal.TryParse(fiyatText, out decimal fiyat))
            {
                MessageBox.Show("Geçerli bir fiyat giriniz.");
                return;
            }

            if (!int.TryParse(odaSayisiText, out int odaSayisi))
            {
                MessageBox.Show("Geçerli bir oda sayısı giriniz.");
                return;
            }

            string connectionString = @"DATA SOURCE=localhost\SQLEXPRESS;INITIAL CATALOG=TinyHouseProject;INTEGRATED SECURITY=TRUE";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Evler 
                             SET Baslik = @Baslik, Aciklama = @Aciklama, GecelikFiyat = @Fiyat, 
                                 Il = @Il, Ilce = @Ilce, Adres = @Adres, OdaSayisi = @OdaSayisi, EvAktif = @EvAktif
                             WHERE EvID = @EvID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Baslik", baslik);
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama);
                    cmd.Parameters.AddWithValue("@Fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@Il", il);
                    cmd.Parameters.AddWithValue("@Ilce", ilce);
                    cmd.Parameters.AddWithValue("@Adres", adres);
                    cmd.Parameters.AddWithValue("@OdaSayisi", odaSayisi);
                    cmd.Parameters.AddWithValue("@EvAktif", evAktif);
                    cmd.Parameters.AddWithValue("@EvID", evID);

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("İlan başarıyla güncellendi.");
                        IlanlariYukle();
                        grp_guncelle.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void dataGridViewIlanlar_SelectionChanged_1(object sender, EventArgs e)
        {
            this.dataGridViewIlanlar.SelectionChanged += new System.EventHandler(this.dataGridViewIlanlar_SelectionChanged);

        }
    }
}
