using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Users
{
    interface UserAdapter
    {
        object[] GetInfo();
        void ChangeName(string password, string newName);
        void ChangeLogin(string password, string newLogin);
        void ChangePassword(string oldPassword, string newPassword);
    }
}
