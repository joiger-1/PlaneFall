using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneFall.Classes.Users.UserTypes.UserAccesType
{
    class Client : AutorizationUser
    {
        public Client(int id, string name, string login, string passwordHash) : base(id, name, login, passwordHash)
        {
        }

        public override Form GetMainForm()
        {
            throw new NotImplementedException();
        }
    }
}
