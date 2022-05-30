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
    /// Логика взаимодействия для pcpage.xaml
    /// </summary>
    public partial class pcpage : Page
    {
        private readonly int? new_id_user;

        public static ObservableCollection<Prise> prises { get; set; }
        int y { get; set; }
        public pcpage(int _id_user)
        {
            InitializeComponent();
            new_id_user = _id_user;
        }

        private void btn_count_Click(object sender, RoutedEventArgs e)
        {
            
            int s = 0;
            int ch = 240;
            s = Convert.ToInt32(tb_amount.Text) * ch;
            prise.Content = s;
        }

        private void btn_choose_Click(object sender, RoutedEventArgs e)
        {
            var b = new Prise();
            b.prise1 = prise.Content.ToString();
            b.id_user = new_id_user;
            MessageBox.Show("Запись сделана");
            bd_connection.connection.Prise.Add(b);
            bd_connection.connection.SaveChanges();
            NavigationService.Navigate(new addpage());
            
        }

        private void btn_nigch_Click(object sender, RoutedEventArgs e)
        {
            var v = new Prise();
            v.prise1 = prisenght.Text.ToString();
            v.id_user = new_id_user;
            MessageBox.Show("Запись сделана");
            Class1.AddPrisePc(v);
            NavigationService.Navigate(new addpage());
        }
        
        private void tb_amount_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
