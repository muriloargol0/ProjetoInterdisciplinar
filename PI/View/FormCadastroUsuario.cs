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
    public partial class FormCadastroUsuario : Form
    {
        private static bool _opened = false;
        public bool isOpened
        {
            get
            {
                return _opened;
            }

            set
            {
                _opened = true;
            }
        }
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(((Button)(sender)).Tag) == 0)
            {
                ((Button)(sender)).Tag = 1;
                txtSenha.PasswordChar = '\u0000';
            }
            else
            {
                ((Button)(sender)).Tag = 0;
                txtSenha.PasswordChar = '*';
            }
                
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helper.Helper.LimparCampos(this.Controls);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
