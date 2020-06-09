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
            
            var isLogged = l.DoLogin(txtLogin.Text, txtSenha.Text, out msg);

            if (!isLogged)
            {
                MessageBox.Show(msg);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Dispose();
            }           
        }
    }
}
