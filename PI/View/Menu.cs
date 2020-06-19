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
        private CircuitoController _cc = null;
        private ProjetoController _pc = null;
        public Menu()
        {
            InitializeComponent();
        }

        #region Circuitos
        private void btnCadastrarCircuito_Click(object sender, EventArgs e)
        {
            //Instancia o controller que será compartilhado entre as duas telas (Busca/Cadastro)
            if (_cc == null)
                _cc = new CircuitoController();
          
            FormBuscaCircuito bc = new FormBuscaCircuito(_cc);

            if (!_cc.isFormBuscaOpened)
            {
                _cc.isFormBuscaOpened = true;
                bc.MdiParent = this.MdiParent;
                bc.Show();
            }
            else
            {
                MessageBox.Show("Esta janela já está aberta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

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

        private void btnProjeto_Click(object sender, EventArgs e)
        {
            //Instancia o controller que será compartilhado entre as duas telas (Busca/Cadastro)
            if (_pc == null)
                _pc = new ProjetoController();

            FormBuscaProjeto bp = new FormBuscaProjeto(_pc);

            if (!_pc.isFormBuscaOpened)
            {
                _pc.isFormBuscaOpened = true;
                bp.MdiParent = this.MdiParent;
                bp.Show();
            }
            else
            {
                MessageBox.Show("Esta janela já está aberta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
