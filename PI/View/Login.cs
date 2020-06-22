using PI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnENTRAR_Click(object sender, EventArgs e)
        {
            LoginController l = new LoginController();
            var msg = string.Empty;

            if (!string.IsNullOrEmpty(txtLogin.Text) && txtLogin.Text != "USUÁRIO")
            {
                if (!string.IsNullOrEmpty(txtSenha.Text) && txtSenha.Text != "SENHA")
                {
                    var isLogged = l.DoLogin(txtLogin.Text, txtSenha.Text, out msg);

                    if (!isLogged)
                    {
                        txtLogin.Text = string.Empty;
                        txtSenha.Text = string.Empty;
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        this.Dispose();
                    }
                }
                else
                {
                    Helper.Helper.ShowMessageError("O campo senha é obrigatório!", "Campo obrigatório");
                }
            }
            else
            {
                Helper.Helper.ShowMessageError("O campo login é obrigatório!", "Campo obrigatório");
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "USUÁRIO")
                ((TextBox)(sender)).Text = string.Empty;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "******")
                ((TextBox)(sender)).Text = string.Empty;
            ((TextBox)(sender)).PasswordChar = '*';
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "")
                ((TextBox)(sender)).Text = "USUÁRIO";
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "")
                ((TextBox)(sender)).Text = "******";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnENTRAR_Click(sender, e);
            }
        }
    }
}
