using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneFall
{
    static class FormController
    {
        private static Stack<Form> _hideForms;
        private static Form _thisForm;

        static FormController()
        {
            _hideForms = new Stack<Form>();
        }
        public static void SetStartForm(Form startForm)
        {
            _thisForm = startForm;
        }
        public static void AddForm(Form form)
        {
            if (_thisForm != null)
            {
                _hideForms.Push(_thisForm);
                _thisForm.Hide();
            }
            _thisForm = form;
            form.Show();
        }
        public static void Close()
        {
            _thisForm.Dispose();
            _thisForm = _hideForms.Pop();
            _thisForm.Show();
        }
        public static void CloseAll()
        {
            while (_hideForms.Any())
                _hideForms.Pop().Dispose();
        }
    }
}
