using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Users
{
    class Users
    {
        private static List<User> _users;

        static Users()
        {
            _users = new List<User>();
        }
        public static void Load()
        {

        }
        public static User GetUser(string login, string password)
        {
            foreach (User user in _users)
            {
                if (user.Verifity(login, password))
                    return user;
            }
            throw new Exception("Пользователь не найден");
        }
    }
}
