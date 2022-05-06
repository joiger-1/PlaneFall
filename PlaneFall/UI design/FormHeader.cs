using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneFall.UI_design
{
    public partial class FormHeader : Form
    {
        private bool _isMoving = false;
        private Point _prefMousePos;
        public FormHeader()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _isMoving = true;
            _prefMousePos = MousePosition;
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMoving)
            {
                Point mouseShift = MousePosition - ((Size)_prefMousePos);

                this.Location += ((Size)mouseShift);

                _prefMousePos = MousePosition;
            }
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _isMoving = false;
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
