using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static void SetUsuarioLogado(int idUser, string login)
        {
            _idUser = idUser;
            _login = login;
        }

        public static void ShowMessageError(string msg, string title)
        {
            MessageBox.Show(msg, title,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static string SomenteNumeros(string str)
        {
            string nstr = string.Empty;

            try
            {
                nstr = Regex.Replace(str, @"(i?)[a-z.,;:áéíóúâêîôûàèìòù\-()[\]{}\+=*'´`´ §/@#$%¨&!^ºª\""]", "",
                                    RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                nstr = string.Empty;
            }

            return nstr;
        }

        public static string SomenteCaracteres(string str)
        {
            string nstr = string.Empty;

            try
            {
                nstr  = Regex.Replace(str, @"[1234567890]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                nstr = string.Empty;
            }

            return nstr;
        }

        public static string SomenteNumerosEPontos(string str)
        {
            string nstr = string.Empty;

            try
            {
                nstr = Regex.Replace(str, @"(i?)[a-záéíóúâêîôûàèìòù\-()[\]{}\+=*'/@#$:;?|%¨&!^ºª\""]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }

            catch (RegexMatchTimeoutException)
            {
                nstr = string.Empty;
            }

            return nstr;
        }

        public static bool ValidaCampos(Control.ControlCollection ctrls)
        {
            var isValid = true;

            foreach (var itens in ctrls)
            {
                if (itens is TextBox)
                {
                    if(Convert.ToInt32(((TextBox)(itens)).Tag) == 1)
                    {
                        if(((TextBox)(itens)).Text == string.Empty)
                        {
                            isValid = false;
                            ((TextBox)(itens)).BackColor = Color.Red;
                            ((TextBox)(itens)).ForeColor = Color.White;
                        }
                        else
                        {
                            isValid = true;
                            ((TextBox)(itens)).BackColor = Color.White;
                            ((TextBox)(itens)).ForeColor = Color.Black;
                        }
                    }
                }

                if (itens is MaskedTextBox)
                {
                    if (Convert.ToInt32(((MaskedTextBox)(itens)).Tag) == 1)
                    {
                        if (((MaskedTextBox)(itens)).Text == string.Empty || ((MaskedTextBox)(itens)).Text.Trim() == ",")
                        {
                            isValid = false;
                            ((MaskedTextBox)(itens)).BackColor = Color.Red;
                            ((MaskedTextBox)(itens)).ForeColor = Color.White;
                        }
                        else
                        {
                            isValid = true;
                            ((MaskedTextBox)(itens)).BackColor = Color.White;
                            ((MaskedTextBox)(itens)).ForeColor = Color.Black;
                        }
                    }
                }

                if (itens is NumericUpDown)
                {
                    if (Convert.ToInt32(((NumericUpDown)(itens)).Tag) == 1)
                    {
                        if (((NumericUpDown)(itens)).Text == string.Empty || ((NumericUpDown)(itens)).Text == "0")
                        {
                            isValid = false;
                            ((NumericUpDown)(itens)).BackColor = Color.Red;
                            ((NumericUpDown)(itens)).ForeColor = Color.White;
                        }
                        else
                        {
                            isValid = true;
                            ((NumericUpDown)(itens)).BackColor = Color.White;
                            ((NumericUpDown)(itens)).ForeColor = Color.Black;
                        }
                    }
                }

                if (itens is RichTextBox)
                {
                    if (Convert.ToInt32(((RichTextBox)(itens)).Tag) == 1)
                    {
                        if (((RichTextBox)(itens)).Text == string.Empty)
                        {
                            isValid = false;
                            ((RichTextBox)(itens)).BackColor = Color.Red;
                            ((RichTextBox)(itens)).ForeColor = Color.White;
                        }
                        else
                        {
                            isValid = true;
                            ((RichTextBox)(itens)).BackColor = Color.White;
                            ((RichTextBox)(itens)).ForeColor = Color.Black;
                        }
                    }
                }
            }

            return isValid;
        }
    }
}
