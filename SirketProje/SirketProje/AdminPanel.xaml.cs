using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace SirketProje
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        public string Mail;
        CompanyEntities db = new CompanyEntities();
        public static AdminPanel adminpanel;
        


        void Foto()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).FirstOrDefault();
            var bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(Person.PersonelFoto);
            bi.EndInit();

            //var img = new Image();
            image1.ImageSource = bi;
        }

        public void Temizle()
        {
            textPersonelID.Text = "";
            txtUserAd.Text = "";
            txtUserSoyad.Text = "";
            txtMaas.Text = "";
            cmDepartman.Text = "";
            cmbSube.Text = "";
            txtMail.Text = "";
            txtTelefon.Text = "";
            rchHakkinda.Document.Blocks.Clear();
            txtSifre.Text = "";
            txtFoto.Text = "";
        }

        void PersonelList()
        {
            //datagrid1.ItemsSource = (from x in db.Personeller
            //                         select new
            //                         {
            //                             x.ID,
            //                             x.PersonelAd,
            //                             x.PersonelSoyad,
            //                             x.Maas,
            //                             x.Departman1.DepartmanAd,
            //                             x.Subeler.SubeAd,
            //                             x.Telefon,
            //                             x.Mail,
            //                             x.PersonelSifre,
            //                             x.Hakkinda,
            //                             x.PersonelFoto
            //                         }).ToList();

            SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=Company;Integrated Security=True; MultipleActiveResultSets=True");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Personeller.ID, PersonelAd,PersonelSoyad, Maas,Departman.DepartmanAd, Subeler.SubeAd, Personeller.Telefon,Personeller.Mail,PersonelSifre,PersonelFoto,Hakkinda from Personeller  inner join Departman on Personeller.Departman = Departman.ID  inner join Subeler on Personeller.Sube = Subeler.ID ", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid1.ItemsSource = dt.DefaultView;
            connect.Close();
        }

        void PersonelAdSoyad()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).FirstOrDefault();

            textAd.Text = Person.PersonelAd + " " + Person.PersonelSoyad;
        }

        void Maas()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).FirstOrDefault();
            textMaas.Text = Person.Maas + " ₺";
        }

        void Departman()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).FirstOrDefault();

            textDepartman.Text = Person.Departman1.DepartmanAd;
        }

        void Hakkinda()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).FirstOrDefault();

            textHakkinda.Text = Person.Hakkinda;
        }

        void Sube()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).FirstOrDefault();

            textSube.Text = Person.Subeler.SubeAd;
        }

        void MuhendisSayi()
        {
            int muhendisSayi = (from i in db.Personeller where i.Departman == 3 select i).Count();
            int muhendisSayi2 = (from i in db.Personeller where i.Departman == 4 select i).Count();

            int toplam = muhendisSayi + muhendisSayi2;
            textMuhendisSayi.Text = toplam.ToString();
        }

        void PersonelSayi()
        {
            int PersonelSayi = db.Personeller.Count();
            textPersonel.Text = PersonelSayi.ToString();
        }

        void DepartmanSayi()
        {
            int DepartmanSayi = db.Departman.Count();
            textdepartman2.Text = DepartmanSayi.ToString();
        }

        void SubeSayi()
        {
            int SubeSayi = db.Subeler.Count();
            txtSube.Text = SubeSayi.ToString();
        }

        void Subeler()
        {
            var Subeler = (from x in db.Subeler  // ENTITY
                           select new
                           {
                               x.SubeAd,
                               x.ID,

                           }).ToList();
            cmbSube.DisplayMemberPath = "SubeAd";
            cmbSube.SelectedValuePath = "ID";
            cmbSube.ItemsSource = Subeler;
        }

        void Departmanlar()
        {
            var Departmanlar = (from x in db.Departman  // ENTITY
                                select new
                                {
                                    x.DepartmanAd,
                                    x.ID,

                                }).ToList();
            cmDepartman.DisplayMemberPath = "DepartmanAd";
            cmDepartman.SelectedValuePath = "ID";
            cmDepartman.ItemsSource = Departmanlar;
        }

        public void Listele()
        {
            Foto();
            PersonelAdSoyad();
            Departman();
            Maas();
            Hakkinda();
            Sube();
            MuhendisSayi();
            PersonelSayi();
            DepartmanSayi();
            SubeSayi();
            PersonelList();
            Departmanlar();
            Subeler();
            Temizle();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            adminpanel = this;
            Listele();
        }

        private void Geri_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void cmDepartman_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid satir = (DataGrid)sender;
            DataRowView satir1 = satir.SelectedItem as DataRowView;
            if (satir1 != null)
            {
                textPersonelID.Text = satir1["ID"].ToString();
                txtUserAd.Text = satir1["PersonelAd"].ToString();
                txtUserSoyad.Text = satir1["PersonelSoyad"].ToString();
                txtMaas.Text = satir1["Maas"].ToString();
                cmbSube.Text = satir1["SubeAd"].ToString();
                cmDepartman.Text = satir1["DepartmanAd"].ToString();
                txtTelefon.Text = satir1["Telefon"].ToString();
                txtMail.Text = satir1["Mail"].ToString();
                txtSifre.Text = satir1["PersonelSifre"].ToString();
                txtFoto.Text = satir1["PersonelFoto"].ToString();
                rchHakkinda.Document.Blocks.Clear();
                rchHakkinda.Document.Blocks.Add(new Paragraph(new Run(satir1["Hakkinda"].ToString())));
            }
        }



        private void Ekle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Personeller p = new Personeller();
                p.PersonelAd = txtUserAd.Text;
                p.PersonelSoyad = txtUserSoyad.Text;
                p.Maas = txtMaas.Text;
                p.Departman = int.Parse(cmDepartman.SelectedValue.ToString());
                p.Sube = int.Parse(cmbSube.SelectedValue.ToString());
                p.Telefon = txtTelefon.Text;
                p.Mail = txtMail.Text;
                p.PersonelSifre = txtSifre.Text;
                p.PersonelFoto = txtFoto.Text;
                p.Durum = true;
                string hakkinda = new TextRange(rchHakkinda.Document.ContentStart, rchHakkinda.Document.ContentEnd).Text;
                p.Hakkinda = hakkinda;
                db.Personeller.Add(p);
                db.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Eksik Bilgi Doldurdunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                MessageBox.Show("Personel Sisteme Kayıt Edildi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                Listele();
                Temizle();
            }
        }

        private void Sil_Click(object sender, RoutedEventArgs e)
        {
            var personel = db.Personeller.Find(Convert.ToInt32(textPersonelID.Text));
            db.Personeller.Remove(personel);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            Listele();
            Temizle();
        }

        private void Guncelle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Person = db.Personeller.Find(Convert.ToInt32(textPersonelID.Text));
                Person.PersonelAd = txtUserAd.Text;
                Person.PersonelSoyad = txtUserSoyad.Text;
                Person.Maas = txtMaas.Text;
                Person.Departman = int.Parse(cmDepartman.SelectedValue.ToString());
                Person.Sube = int.Parse(cmbSube.SelectedValue.ToString());
                Person.Telefon = txtTelefon.Text;
                Person.Mail = txtMail.Text;
                Person.PersonelSifre = txtSifre.Text;
                Person.PersonelFoto = txtFoto.Text;
                string Hakkinda = new TextRange(rchHakkinda.Document.ContentStart, rchHakkinda.Document.ContentEnd).Text;
                Person.Hakkinda = Hakkinda;
                db.SaveChanges();


            }
            catch (Exception)
            {
                MessageBox.Show("Eksik Bilgi Doldurdunuz.", "UYARI", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                MessageBox.Show("Personel Başarıyla Güncellendi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                Listele();
                Temizle();
            }
        }

        private void Temizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        private void Departman_Click(object sender, RoutedEventArgs e)
        {
            SayfaDepartmant sd = new SayfaDepartmant();
            sd.Show();
        }

        private void Sube_Click(object sender, RoutedEventArgs e)
        {
            SayfaSube ss = new SayfaSube();
            ss.Show();
        }
    }
}
