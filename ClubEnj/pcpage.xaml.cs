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
    /// Логика взаимодействия для pcpage.xaml
    /// </summary>
    public partial class pcpage : Page
    {
        public static ObservableCollection<Prise> prises { get; set; }
        int y { get; set; }
        public pcpage()
        {
            InitializeComponent();
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
            //b.id_prise = ;
        }

        private void btn_nigch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void prise_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
