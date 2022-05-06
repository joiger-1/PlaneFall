using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneFall.Classes.Other;
using PlaneFall.Classes.Users.UserTypes.UserAccesType;

namespace PlaneFall.Classes.Users
{
    class Users
    {
        private static List<User> _users;
        public static User Guest
        {
            get => new Guest();
        }
        static Users()
        {
            _users = new List<User>();
        }
        public static void Load()
        {
            object[][] data = Database.GetTable("Users");

            (int id, string name, string login, string passwordHash, string type)[] users 
                = data.Select(x => ((int)x[0], x[1] as string, x[2] as string, x[3] as string, x[4] as string)).ToArray();

            foreach (var userData in users)
            {
                User tempUser;
                switch (userData.type)
                {
                    case "SuperAdmin":
                        tempUser = new SuperAdmin(userData.id, userData.name, userData.login, userData.passwordHash);
                        break;
                    case "Admin":
                        tempUser = new Admin(userData.id, userData.name, userData.login, userData.passwordHash);
                        break;
                    case "Operator":
                        tempUser = new Operator(userData.id, userData.name, userData.login, userData.passwordHash);
                        break;
                    case "Client":
                        tempUser = new Client(userData.id, userData.name, userData.login, userData.passwordHash);
                        break;
                    default:
                        throw new Exception("Неизветный тип прав доступа");
                }
                _users.Add(tempUser);
            }
        }
        public static void LogIn(string login, string password)
        {
            foreach (User user in _users)
            {
                if (user.Verifity(login, password))
                {
                    user.GetMainForm().Show();
                    return;
                }
            }
            throw new Exception("Пользователь не найден");
        }
    }
}
