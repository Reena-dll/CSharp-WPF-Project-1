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
    /// Interaction logic for SayfaSube.xaml
    /// </summary>
    public partial class SayfaSube : Window
    {
        public SayfaSube()
        {
            InitializeComponent();
        }

        CompanyEntities db = new CompanyEntities();
        void Temizle()
        {
            txtMail.Text = "";
            txtSubeAd.Text = "";
            txtTelefon.Text = "";
            txtSubeID.Text = "";
        }

        void Listele()
        {
            SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=Company;Integrated Security=True; MultipleActiveResultSets=True");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ID, SubeAd, Telefon,Mail from Subeler", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid1.ItemsSource = dt.DefaultView;
            connect.Close();
        }

        private void Temizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        private void Geri_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Listele();
            Temizle();

        }

        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid satir = (DataGrid)sender;
            DataRowView satir1 = satir.SelectedItem as DataRowView;
            if (satir1 != null)
            {
                txtMail.Text = satir1["Mail"].ToString();
                txtSubeAd.Text = satir1["SubeAd"].ToString();
                txtSubeID.Text = satir1["ID"].ToString();
                txtTelefon.Text = satir1["Telefon"].ToString();

            }
        }

        private void Ekle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Subeler p1 = new Subeler();
                p1.SubeAd = txtSubeAd.Text;
                p1.Mail = txtMail.Text;
                p1.Telefon = txtTelefon.Text;
                p1.Durum = true;
                db.Subeler.Add(p1);
                db.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Eksik Bilgi Doldurdunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                MessageBox.Show("Şube Sisteme Kayıt Edildi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                Listele();
                Temizle();
                AdminPanel.adminpanel.Listele();
                AdminPanel.adminpanel.Temizle();

            }
        }

        private void Guncelle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var p1 = db.Subeler.Find(Convert.ToInt32(txtSubeID.Text));
                p1.SubeAd = txtSubeAd.Text;
                p1.Mail = txtMail.Text;
                p1.Telefon = txtTelefon.Text;
                db.SaveChanges();


            }
            catch (Exception)
            {
                MessageBox.Show("Eksik Bilgi Doldurdunuz.", "UYARI", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                MessageBox.Show("Şube Başarıyla Güncellendi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                Listele();
                Temizle();
                AdminPanel.adminpanel.Listele();
                AdminPanel.adminpanel.Temizle();
            }
        }

        private void Sil_Click(object sender, RoutedEventArgs e)
        {
            var subelerr = db.Subeler.Find(Convert.ToInt32(txtSubeID.Text));
            db.Subeler.Remove(subelerr);
            db.SaveChanges();
            MessageBox.Show("Şube Başarıyla Silindi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            Listele();
            Temizle();
            AdminPanel.adminpanel.Listele();
            AdminPanel.adminpanel.Temizle();

        }
    }
}
