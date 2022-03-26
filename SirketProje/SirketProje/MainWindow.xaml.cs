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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SirketProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        CompanyEntities db = new CompanyEntities();

        void Temizle()
        {
            textMail.Text = "";
            textSifre.Password = "";
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Cikis_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Çıkmak İstiyor Musunuz?", "Bilgi", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Giris_Click(object sender, RoutedEventArgs e)
        {
            Personeller k = db.Personeller.Where(x => x.Mail == textMail.Text && x.PersonelSifre == textSifre.Password && x.Departman==1).FirstOrDefault();

            if (k == null)
            {
                Personeller l = db.Personeller.Where(x => x.Mail == textMail.Text && x.PersonelSifre == textSifre.Password).SingleOrDefault();
                if (l == null)
                {
                    MessageBox.Show("Girmiş Olduğunuz Mail veya Şifre Yanlış.", "UYARI", MessageBoxButton.OK, MessageBoxImage.Error);
                    Temizle();
                }
                else
                {
                    // Normal Kullanıcı Girişi Kullanıcı Paneli
                    KullaniciPaneli kp = new KullaniciPaneli();
                    kp.Mail = textMail.Text;
                    kp.Show();
                    this.Hide();
                }
               
            }

            if (k != null)
            {

                MessageBoxResult result = MessageBox.Show("Yönetici Tespit Edildi. Admin Paneline Girmek İstiyor Musunuz?", "Bilgi", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    // Admin Paneli Yönetici İçin
                    AdminPanel ap = new AdminPanel();
                    ap.Mail = textMail.Text;
                    ap.Show();
                    this.Hide();
                }
                else
                {
                    // Kullanıcı Paneli Yönetici İçin
                    KullaniciPaneli kp = new KullaniciPaneli();
                    kp.Mail = textMail.Text;
                    kp.Show();
                    this.Hide();

                }

            }
        }
    }
}
