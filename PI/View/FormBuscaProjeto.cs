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
    public partial class FormBuscaProjeto : Form
    {
        private ProjetoController _projetoController = null;
        private FormCadastroProjeto _cp = null;
        public FormBuscaProjeto(ProjetoController pc)
        {
            _projetoController = pc;
            InitializeComponent();
        }

        public ProjetoController GetProjetoController()
        {
            return _projetoController;
        }

        private void OpenFormCadastro(int Id = 0)
        {

            //Se o cadastro já foi fechado, ele limpa a variável que armazena a instância do objeto
            if (!GetProjetoController().isFormCadastroOpened)
                _cp = null;

            //Se for nula, um novo objeto é criado
            if (_cp == null)
                _cp = new FormCadastroProjeto(GetProjetoController());

            //Se houver ID quer dizer que estamos editando um registro
            if (Id > 0)
                _cp.SetEditId = Id;

            //Verifica se já existe uma tela aberta
            if (!GetProjetoController().isFormCadastroOpened)
            {
                GetProjetoController().isFormCadastroOpened = true;
                //_uc.MdiParent = this.MdiParent;
                _cp.ShowDialog();

                if (_cp.DialogResult == DialogResult.OK)
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

        private void PreencheGrid(string param = "")
        {
            if (param == "")
            {
                Lista.DataSource = GetProjetoController().GetProjetos();
            }
            else
            {
                Lista.DataSource = GetProjetoController().GetProjetos(param);
            }


            for (int i = 0; i < Lista.ColumnCount; i++)
            {
                if (Lista.Columns[i].Name.ToUpper() == "idProjeto".ToUpper())
                {
                    Lista.Columns[i].HeaderText = "ID";
                }
                else
                {
                    if (Lista.Columns[i].Name.ToUpper() == "descricao".ToUpper())
                    {
                        Lista.Columns[i].HeaderText = "DESCRIÇÃO";
                        Lista.Columns[i].Width = 500;
                    }
                    else
                    {
                        if (Lista.Columns[i].Name.ToUpper() == "entradas".ToUpper())
                        {
                            Lista.Columns[i].HeaderText = "ENTRADAS";
                            Lista.Columns[i].Width = 150;
                        }
                        else
                        {
                            Lista.Columns[i].Visible = false;
                        }
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            OpenFormCadastro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(Lista.SelectedRows.Count > 0)
                OpenFormCadastro(Convert.ToInt32(Lista.CurrentRow.Cells[0].Value.ToString()));
        }

        private void Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenFormCadastro(Convert.ToInt32(Lista.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedRows.Count > 0)
            {
                string message = $"Deseja realmente excluir o projeto {Lista.CurrentRow.Cells[1].Value.ToString()}?";
                string caption = "Excluir";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GetProjetoController().Delete(Convert.ToInt32(Lista.CurrentRow.Cells[0].Value.ToString()));
                    PreencheGrid();
                }
            }
        }

        private void FormBuscaProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetProjetoController().isFormBuscaOpened = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscaProjeto_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscaDescricao.Text))
            {
                PreencheGrid(txtBuscaDescricao.Text.ToString());
            }
            else
            {
                PreencheGrid();
            }
        }
    }
}
