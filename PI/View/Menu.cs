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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrarCircuito_Click(object sender, EventArgs e)
        {
            FormBuscaCircuito bc = new FormBuscaCircuito();
            if (!bc.isOpened)
            {
                bc.isOpened = true;
                bc.MdiParent = this.MdiParent;
                bc.Show();
            }
            else
            {
                MessageBox.Show("Esta janela já está aberta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if(Helper.Helper.GetIdUser() == 1)
            {
                FormBuscaUsuario bu = new FormBuscaUsuario();

                if (!bu.isOpened)
                {
                    bu.isOpened = true;
                    bu.MdiParent = this.MdiParent;
                    bu.Show();
                }
                else
                {
                    MessageBox.Show("Esta janela já está aberta!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                FormCadastroUsuario uc = new FormCadastroUsuario();

                if (!uc.isOpened)
                {
                    uc.isOpened = true;
                    uc.MdiParent = this.MdiParent;
                    uc.Show();
                }
                else
                {
                    MessageBox.Show("Esta janela já está aberta!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
