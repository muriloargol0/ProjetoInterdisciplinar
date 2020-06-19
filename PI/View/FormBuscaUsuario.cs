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
    public partial class FormBuscaUsuario : Form
    {
        private UserController _userController = null;
        private FormCadastroUsuario _uc = null;

        public FormBuscaUsuario(UserController uc)
        {
            _userController = uc;
            InitializeComponent();
        }

        private void OpenFormCadastro(int Id = 0)
        {
            
            //Se o cadastro já foi fechado, ele limpa a variável que armazena a instância do objeto
            if (!GetUserController().isFormCadastroOpened)
                _uc = null;

            //Se for nula, um novo objeto é criado
            if (_uc == null)
                _uc = new FormCadastroUsuario(GetUserController());

            //Se houver ID quer dizer que estamos editando um registro
            if (Id > 0)
                _uc.SetEditId = Id;

            //Verifica se já existe uma tela aberta
            if (!GetUserController().isFormCadastroOpened)
            {
                GetUserController().isFormCadastroOpened = true;
                //_uc.MdiParent = this.MdiParent;
                _uc.ShowDialog();

                if(_uc.DialogResult == DialogResult.OK)
                {
                    PreencheGrid();
                }

            }
            else
            {
                MessageBox.Show("Esta janela já está aberta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public UserController GetUserController()
        {
            return _userController;
        }
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            OpenFormCadastro();
        }

        private void PreencheGrid(string param = "")
        {
            if(param == "")
            {
                Lista.DataSource = GetUserController().GetUsuarios();
            }
            else
            {
                Lista.DataSource = GetUserController().GetUsuarios(param);
            }
            

            for (int i = 0; i < Lista.ColumnCount; i++)
            {
                if (Lista.Columns[i].Name.ToUpper() == "iduser".ToUpper())
                {
                    Lista.Columns[i].HeaderText = "ID";
                }
                else
                {
                    if (Lista.Columns[i].Name.ToUpper() == "nome".ToUpper())
                    {
                        Lista.Columns[i].HeaderText = "NOME";
                        Lista.Columns[i].Width = 300;
                    }
                    else
                    {
                        if (Lista.Columns[i].Name.ToUpper() == "email".ToUpper())
                        {
                            Lista.Columns[i].HeaderText = "EMAIL";
                            Lista.Columns[i].Width = 250;
                        }
                        else
                        {
                            if (Lista.Columns[i].Name.ToUpper() == "login".ToUpper())
                            {
                                Lista.Columns[i].HeaderText = "LOGIN";
                            }
                            else
                            {
                                Lista.Columns[i].Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void FormBuscaUsuario_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetUserController().isFormBuscaOpened = false;
        }

        private void EditarDados(object sender, System.EventArgs e)
        {
            OpenFormCadastro(Convert.ToInt32(Lista.CurrentRow.Cells[0].Value.ToString()));
        }

        private void Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarDados(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBuscaNome.Text))
            {
                PreencheGrid(txtBuscaNome.Text.ToString());
            }
            else
            {
                PreencheGrid();
            }  
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedRows.Count > 0)
            {
                string message = $"Deseja realmente excluir o usuário {Lista.CurrentRow.Cells[1].Value.ToString()}?";
                string caption = "Excluir";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GetUserController().Delete(Convert.ToInt32(Lista.CurrentRow.Cells[0].Value.ToString()));
                    PreencheGrid();
                }
            }
        }
    }
}
