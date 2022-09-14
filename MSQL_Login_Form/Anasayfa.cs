using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MSQL_Login_Form
{
    public partial class Anasayfa : Form
    {

        public Anasayfa()
        {
            InitializeComponent();
        }

        private bool surukle = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void pnl_AnasayfaTop_MouseDown(object sender, MouseEventArgs e)
        {
            surukle = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnl_AnasayfaTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukle)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnl_AnasayfaTop_MouseUp(object sender, MouseEventArgs e)
        {
            surukle = false;
        }

        private void btn_AnasayfaCikis_Click(object sender, EventArgs e)
        {
            //komple kapatma
            Application.ExitThread();
        }

        private void btn_Anasayfa_Rapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();
            this.Hide();
        }
        private void btn_Anasayfa_Katagoriler_Click(object sender, EventArgs e)
        {
            Katagoriler katagoriler = new Katagoriler();
            katagoriler.Show();
        }

        private void btn_AnaSayfa_Hesap_Click(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();
            hesap.Show();
        }

        private void btn_Anasayfa_ZimmetGiris_Click(object sender, EventArgs e)
        {
            ZimmetGiris zimmetgiris = new ZimmetGiris();
            zimmetgiris.Show();
        }

        private void btn_Anasayfa_Yonetici_Click(object sender, EventArgs e)
        {
            HesapEkle hesapekle = new HesapEkle();
            hesapekle.Show();
        }

        private void fillChart()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=192.168.60.128;Initial Catalog=demirbas;User ID=sa;Password=Berat123456789");

            DataSet ds = new DataSet();

            baglanti.Open();

            // sql stun sayısını hesaplattık
            string sql = "Select count(URUN) from demirbasGirisListe";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            int stun = Convert.ToInt32(cmd.ExecuteScalar());

            SqlDataAdapter adapt = new SqlDataAdapter("Select URUN from demirbasGirisListe", baglanti);


            baglanti.Close();

            lbl_UrunToplam.Text = Convert.ToString(stun);

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
