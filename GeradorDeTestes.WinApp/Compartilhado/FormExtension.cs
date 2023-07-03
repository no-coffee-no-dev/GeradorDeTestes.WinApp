using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.Compartilhado
{
    public static class FormExtension
    {
        public static void ConfigurarDialog(this Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.ShowIcon = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.StartPosition = FormStartPosition.CenterScreen;
        }

    }
}
