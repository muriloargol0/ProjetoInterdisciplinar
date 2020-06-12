using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.Helper
{
    static class Helper
    {
        private static int _idUser = 0;
        private static string _login = string.Empty;

        public static int GetIdUser()
        {
            return _idUser;
        }

        public static string GetLoginUser()
        {
            return _login;
        }

        public static void setUsuarioLogado(int idUser, string login)
        {
            _idUser = idUser;
            _login = login;
        }
        public static void LimparCampos(Control.ControlCollection ctrls)
        {
            foreach (var itens in ctrls)
            {
                if (itens is TextBox)
                    ((TextBox)(itens)).Text = string.Empty;
                if (itens is MaskedTextBox)
                    ((MaskedTextBox)(itens)).Text = string.Empty;
                if (itens is NumericUpDown)
                    ((NumericUpDown)(itens)).Value = 0;
                if (itens is RichTextBox)
                    ((RichTextBox)(itens)).Text = string.Empty;
            }
        }
    }
}
