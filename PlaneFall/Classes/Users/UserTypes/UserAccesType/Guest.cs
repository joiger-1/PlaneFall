using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneFall.Classes.Users.UserTypes.UserAccesType
{
    class Guest : User, UserAdapter
    {
        private string _name;

        public override Form GetMainForm()
        {
            throw new NotImplementedException();
        }

        public override bool Verifity(string login, string password)
        {
            throw new Exception("Гость не требует авторизации");
        }

        public void ChangeName(string password, string newName)
        {
            _name = newName;
        }

        public void ChangeLogin(string password, string newLogin)
        {
            throw new Exception("Гость не имеет логина");
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            throw new Exception("Гость не имеет пароля");
        }

        public object[] GetInfo()
        {
            return new object[] { _name };
        }
    }
}
