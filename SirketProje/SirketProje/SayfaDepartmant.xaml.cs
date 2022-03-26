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
    /// Interaction logic for SayfaDepartmant.xaml
    /// </summary>
    public partial class SayfaDepartmant : Window
    {
        public SayfaDepartmant()
        {
            InitializeComponent();
        }
        CompanyEntities db = new CompanyEntities();
        void Listele()
        {
            SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=Company;Integrated Security=True; MultipleActiveResultSets=True");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ID, DepartmanAd, DepartmanGorev  from Departman", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid1.ItemsSource = dt.DefaultView;
            connect.Close();
        }

        void Temizle()
        {
            txtDepartmanAd.Text = "";
            textDepartmanID.Text = "";
            txtDepartmanGorev.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Listele();
            Temizle();
        }

        private void Geri_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid satir = (DataGrid)sender;
            DataRowView satir1 = satir.SelectedItem as DataRowView;
            if (satir1 != null)
            {
                txtDepartmanAd.Text = satir1["DepartmanAd"].ToString();
                txtDepartmanGorev.Text = satir1["DepartmanGorev"].ToString();
                textDepartmanID.Text = satir1["ID"].ToString();
               
            }
        }

        private void Temizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        private void Ekle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Departman p1 = new Departman();
                p1.DepartmanAd = txtDepartmanAd.Text;
                p1.DepartmanGorev = txtDepartmanGorev.Text;
                p1.Durum = true;
                db.Departman.Add(p1);
                db.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Eksik Bilgi Doldurdunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                MessageBox.Show("Departman Sisteme Kayıt Edildi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
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
                var p1 = db.Departman.Find(Convert.ToInt32(textDepartmanID.Text));
                p1.DepartmanAd = txtDepartmanAd.Text;
                p1.DepartmanGorev = txtDepartmanGorev.Text; 
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
                AdminPanel.adminpanel.Listele();
                AdminPanel.adminpanel.Temizle();
            }
        }

        private void Sil_Click(object sender, RoutedEventArgs e)
        {
            var departman = db.Departman.Find(Convert.ToInt32(textDepartmanID.Text));
            db.Departman.Remove(departman);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            Listele();
            Temizle();
            AdminPanel.adminpanel.Listele();
            AdminPanel.adminpanel.Temizle();

        }
    }
}
