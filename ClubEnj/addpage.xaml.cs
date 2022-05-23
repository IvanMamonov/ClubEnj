using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ClubEnj
{
    /// <summary>
    /// Логика взаимодействия для addpage.xaml
    /// </summary>
    public partial class addpage : Page
    {
        public static ObservableCollection<Type> types { get; set; }
        int i { get; set; }
        public addpage()
        {
            InitializeComponent();
            cb_gender.ItemsSource = bd_connection.connection.Type.ToList();
            cb_gender.DisplayMemberPath = "title";
        }

        public void btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            var a = new User();
            a.FullName = tb_fi.Text;
            a.Number = tb_number.Text;
            a.id_type = i;
            bd_connection.connection.User.Add(a);
            bd_connection.connection.SaveChanges();
            NavigationService.Navigate(new pcpage());
        }

        public void cb_gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Type;
            i = a.id_type;
            
        }
    }
}
