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

namespace SirketProje
{
    /// <summary>
    /// Interaction logic for KullaniciPaneli.xaml
    /// </summary>
    public partial class KullaniciPaneli : Window
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        public string Mail;
        CompanyEntities db = new CompanyEntities();

        void Foto()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).SingleOrDefault();
            var bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(Person.PersonelFoto);
            bi.EndInit();

            //var img = new Image();
            image1.ImageSource = bi;
        }

        void PersonelAdSoyad()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).SingleOrDefault();

            textAd.Text = Person.PersonelAd + " " + Person.PersonelSoyad;
        }

        void Maas()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).SingleOrDefault();
            textMaas.Text = Person.Maas + " ₺";
        }

        void Departman()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).SingleOrDefault();

            textDepartman.Text = Person.Departman1.DepartmanAd;
        }

        void Hakkinda()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).SingleOrDefault();

            textHakkinda.Text = Person.Hakkinda;
        }

        void Sube()
        {
            Personeller Person = (from i in db.Personeller where i.Mail == Mail select i).SingleOrDefault();

            textSube.Text = Person.Subeler.SubeAd;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Foto();
            PersonelAdSoyad();
            Departman();
            Maas();
            Hakkinda();
            Sube();
        }

        private void Geri_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }
    }
}
