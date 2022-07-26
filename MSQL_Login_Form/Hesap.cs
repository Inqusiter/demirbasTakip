using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MSQL_Login_Form
{
    public partial class Hesap : Form
    {
        public  int PersonelID = Personel.PersonelID;
        public string PersonelAD = Personel.PersonelAD;
        public string PersonelRutbe = Personel.PersonelRutbe;

        SqlDataReader sqlVeriOku;
        SqlCommand sqlKomut;


        public Hesap()
        {
            InitializeComponent();

        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {


            if ((txt_Sifre1.Text== txt_Sifre2.Text )&& ( String.IsNullOrEmpty(txt_Sifre1.Text) && (String.IsNullOrEmpty(txt_Sifre2.Text)) ))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Bilgiler kayıt edilsin mi?", "Kayıt", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    // veri tabanı nesne olarak tanımlama ve bagalnma
                    SqlConnection baglanti = new SqlConnection("Data Source=192.168.60.128;Initial Catalog=demirbas;User ID=sa;Password=Berat123456789");
                    try
                    {

                        string veriKaydet = "UPDATE  personel  SET PAROLA = '" + txt_Sifre2.Text + "'  WHERE ID = '" + PersonelID + "'";

                        SqlCommand sc2 = new SqlCommand(veriKaydet, baglanti);

                        //sql baglandik
                        baglanti.Open();

                        // sorgu sonucu bir şey okuttuk ve ekledik bunu kullandık
                        sc2.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Veri güncellendi");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("HATA!");
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Yapılmadı! Şifre Kutularından Birisi Boş Veya Şifreler Uyuşmuyor!");
                }

            }

 

        }


        private bool surukle = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void pnl_GirisTop_MouseDown(object sender, MouseEventArgs e)
        {
            surukle = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnl_GirisTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukle)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnl_GirisTop_MouseUp(object sender, MouseEventArgs e)
        {
            surukle = false;
        }

        private void btn_GirisKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_HesapCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
