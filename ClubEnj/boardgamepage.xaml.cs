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


namespace ClubEnj
{
    /// <summary>
    /// Логика взаимодействия для boardgamepage.xaml
    /// </summary>
    public partial class boardgamepage : Page
    {
        private readonly int? new_id_user;

        public static ObservableCollection<Prise> prises { get; set; }
        public boardgamepage(int _id_user)
        {
            InitializeComponent();
            new_id_user = _id_user;
        }
        private void tb_kolvoch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_nigch_Click(object sender, RoutedEventArgs e)
        {
            int s = 0;
            int ch = 240;
            s = Convert.ToInt32(tb_kolvoch.Text) * Convert.ToInt32(tb_kolvoc.Text) * ch;
            prisech.Content = s;
        }

        private void tb_kolvoc_TextChanged(object sender, TextChangedEventArgs e)
        {
            var c = new Prise();
            c.prise1 = prisech.Content.ToString();
            c.id_user = new_id_user;
            MessageBox.Show("Запись сделана");
            bd_connection.connection.Prise.Add(c);
            bd_connection.connection.SaveChanges();
            NavigationService.Navigate(new addpage());
        }
    }
}
