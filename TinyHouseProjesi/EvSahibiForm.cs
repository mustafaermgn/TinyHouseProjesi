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
        }

        private void EvSahibiForm_Load(object sender, EventArgs e)
        {
            IlanlariYukle();
        }

        private void IlanlariYukle()
        {
            string connectionString = @"DATA SOURCE=localhost\SQLEXPRESS;INITIAL CATALOG=TinyHouseProject;INTEGRATED SECURITY=TRUE";

            string query = @"
        SELECT e.EvID, e.Baslik, e.GecelikFiyat, e.OdaSayisi, e.Il, e.Ilce, e.Adres, e.Aciklama, e.EvAktif, e.EklenmeTarihi,
               f.FotoURL
        FROM Evler e
        LEFT JOIN (
            SELECT EvID, MIN(FotoURL) as FotoURL
            FROM EvFotoğraflari
            GROUP BY EvID
        ) f ON e.EvID = f.EvID
        WHERE e.kullaniciID = @kullaniciID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciID", 21);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        da.Fill(dt);
                        dataGridViewIlanlar.DataSource = dt;
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
           IlanEkleForm ilanform = new IlanEkleForm();
            ilanform.Show();
        }
        

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRezervasyonOnayla_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRezervasyonReddet_Click(object sender, EventArgs e)
        {
          
        }
    }
}
