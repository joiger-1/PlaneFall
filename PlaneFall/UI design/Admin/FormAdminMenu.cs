using PlaneFall.Classes.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneFall.UI_design.Admin
{
    public partial class FormAdminMenu : Form, PanelForm
    {
        private UserAdapter User;
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return pnMain;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnSeats_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
