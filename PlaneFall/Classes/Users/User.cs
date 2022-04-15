using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneFall.Classes.Users
{
    abstract class User
    {
        public abstract Form GetMainForm();
        public abstract bool Verifity(string login, string password);
    }
}
