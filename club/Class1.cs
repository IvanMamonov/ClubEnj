using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club
{
    public class Class1
    {
        public static ObservableCollection<TypeGame> types { get; set; }
        int i { get; set; }
        public static ObservableCollection<Prise> prises { get; set; }
        public static List<User> GetUser()
        {
            List<User> users = new List<User>(bd_connection.connection.User);
            List<User> users1 = new List<User>();
            return users;
        }
        
        public static User GetUser(string FullName, string Number)
        {
            ObservableCollection<User> users = new ObservableCollection<User>(bd_connection.connection.User);
            var currentUser = users.Where(u => u.FullName == FullName && u.Number == Number).FirstOrDefault();
            return currentUser;
        }


        public static bool AddUsers(User user)
        {
            try
            {
                bd_connection.connection.User.Add(user);
                bd_connection.connection.SaveChanges();
                return true;
            }
            catch
            { return false; }
        }
        public static bool AddPriseBoard(Prise prise)
        {
            try
            {
                bd_connection.connection.Prise.Add(prise);
                bd_connection.connection.SaveChanges();
                return true;
            }
            catch
            { return true; }
        }
        public static bool AddPrisePc(Prise prise)
        {
            try
            {
                bd_connection.connection.Prise.Add(prise);
                bd_connection.connection.SaveChanges();
                return true;
            }
            catch
            { return true; }
        }
        public static bool AddPrisePs(Prise prise)
        {
            try
            {
                bd_connection.connection.Prise.Add(prise);
                bd_connection.connection.SaveChanges();
                return true;
            }
            catch
            { return true; }
        }
    }
}
