using club;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static User user;
        private ObservableCollection<User> users = new ObservableCollection<User>(bd_connection.connection.User);
        static void Main(string[] args)
        {
            bool AddUser = false;
            while (!AddUser)
            {
                Console.WriteLine("[+] Введите имя:");
                string userName = Console.ReadLine();
                Console.WriteLine("[+] Введите номер телефона:");
                string userNumber = Console.ReadLine();
            }
            if (userName != null && userNumber != null)
            {
                User user = new User();
            }
        }
    }
}
