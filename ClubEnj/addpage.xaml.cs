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
using club;

namespace ClubEnj
{
    /// <summary>
    /// Логика взаимодействия для addpage.xaml
    /// </summary>
    public partial class addpage : Page
    {
        public static ObservableCollection<TypeGame> types { get; set; }
        int i { get; set; }
        public addpage()
        {
            InitializeComponent();
            cb_gender.ItemsSource = bd_connection.connection.TypeGame.ToList();
            cb_gender.DisplayMemberPath = "title";
        }

        public void btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            var a = new User();
            a.FullName = tb_fi.Text;
            a.Number = tb_number.Text;
            Class1.AddUser(a);


            if (cb_gender.SelectedIndex == 0) 
            {
                NavigationService.Navigate(new pcpage(a.id_user));
            }
            else if (cb_gender.SelectedIndex == 1)
            {
                NavigationService.Navigate(new pspage(a.id_user));
            }
            else if (cb_gender.SelectedIndex == 2)
            {
                NavigationService.Navigate(new boardgamepage(a.id_user));
            }
        }

        public void cb_gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as TypeGame;
            i = a.id_type;
            
        }

        private void tb_number_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tb_fi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
