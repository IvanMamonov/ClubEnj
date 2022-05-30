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
using System.Collections.ObjectModel;
using club;

namespace ClubEnj
{
    /// <summary>
    /// Логика взаимодействия для pspage.xaml
    /// </summary>
    public partial class pspage : Page
    {
        private readonly int? new_id_user;
        
        int it { get; set; }
        public static ObservableCollection<Prise> prises { get; set; }
        public pspage(int _id_user)
        {
            InitializeComponent();
            cb_ps.ItemsSource = bd_connection.connection.Item.ToList();
            cb_ps.DisplayMemberPath = "item_name";
            new_id_user = _id_user;
        }

        private void cb_ps_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Item;
            it = a.id_item;
        }

        private void btn_cnt_Click(object sender, RoutedEventArgs e)
        {

            if (cb_ps.SelectedIndex == 0) 
            {
                int s = 0;
                int ch = 200;
                s = Convert.ToInt32(tb_amoun.Text) * ch;
                prs.Content = s;
                
            }
            else if (cb_ps.SelectedIndex == 1)
            {
                int s = 0;
                int ch = 340;
                s = Convert.ToInt32(tb_amoun.Text) * ch;
                prs.Content = s;
            }
            else if (cb_ps.SelectedIndex == 2)
            {
                int s = 0;
                int ch = 150;
                s = Convert.ToInt32(tb_amoun.Text) * ch;
                prs.Content = s;
            }
        }

        private void btn_nghtcnt_Click(object sender, RoutedEventArgs e)
        {
            var v = new Prise();
            v.prise1 = prisepsnght.Text.ToString();
            v.id_user = new_id_user;
            MessageBox.Show("Запись сделана");
            bd_connection.connection.Prise.Add(v);
            bd_connection.connection.SaveChanges();
            NavigationService.Navigate(new addpage());
        }

        private void tb_amoun_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_dcnt_Click(object sender, RoutedEventArgs e)
        {
            var b = new Prise();
            b.prise1 = prs.Content.ToString();
            b.id_user = new_id_user;
            MessageBox.Show("Запись сделана");
            Class1.AddPrisePc(b);
            NavigationService.Navigate(new addpage());
        }
    }
}
