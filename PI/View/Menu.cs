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
    public partial class Menu : Form
    {
        private UserController _uc = null;
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

        #region Usuarios
            
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //Instancia o controller que será compartilhado entre as duas telas
            if(_uc == null)
                _uc = new UserController();

            //Verifica o tipo de usuário logado, onde 1 == ADM
            if(Helper.Helper.GetIdUser() == 1)
            {
                //Se for ADM: O usuário terá acesso a lista de usuários, caso contrário não
                FormBuscaUsuario bu = new FormBuscaUsuario(_uc);

                if (!_uc.isFormBuscaOpened)
                {
                    _uc.isFormBuscaOpened = true;
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
                //Se não for ADM apenas a tela de cadastro é aberta diretamente carregando os dados dele
                FormCadastroUsuario uc = new FormCadastroUsuario(_uc);

                if (!_uc.isFormCadastroOpened)
                {
                    _uc.isFormCadastroOpened = true;
                    uc.SetEditId = Helper.Helper.GetIdUser();
                    uc.MdiParent = this.MdiParent;
                    uc.Show();
                }
                else
                {
                    MessageBox.Show("Esta janela já está aberta!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        #endregion
        }
    }
}
