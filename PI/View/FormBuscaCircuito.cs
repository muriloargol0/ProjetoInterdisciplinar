using PI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.View
{
    public partial class FormBuscaCircuito : Form
    {

        private CircuitoController _circuitoController = null;
        private FormCadastroCircuito _cc = null;

        public FormBuscaCircuito(CircuitoController cc)
        {
            _circuitoController = cc;
            InitializeComponent();
        }

        public CircuitoController GetCircuitoController()
        {
            return _circuitoController;
        }

        private void OpenFormCadastro(int Id = 0)
        {

            //Se o cadastro já foi fechado, ele limpa a variável que armazena a instância do objeto
            if (!GetCircuitoController().isFormCadastroOpened)
                _cc = null;

            //Se for nula, um novo objeto é criado
            if (_cc == null)
                _cc = new FormCadastroCircuito(GetCircuitoController());

            //Se houver ID quer dizer que estamos editando um registro
            if (Id > 0)
                _cc.SetEditId = Id;

            //Verifica se já existe uma tela aberta
            if (!GetCircuitoController().isFormCadastroOpened)
            {
                GetCircuitoController().isFormCadastroOpened = true;
                //_uc.MdiParent = this.MdiParent;
                _cc.ShowDialog();

                if (_cc.DialogResult == DialogResult.OK)
                {
                    PreencheGrid();
                }
            }
            else
            {
                Helper.Helper.ShowMessageError("Esta janela já está aberta!", "Erro");
            }
        }


        private void PreencheGrid(string param = "")
        {
            if (param == "")
            {
                Lista.DataSource = GetCircuitoController().GetCircuitos();
            }
            else
            {
                Lista.DataSource = GetCircuitoController().GetCircuitos(param);
            }


            for (int i = 0; i < Lista.ColumnCount; i++)
            {
                if (Lista.Columns[i].Name.ToUpper() == "idCircuito".ToUpper())
                {
                    Lista.Columns[i].HeaderText = "ID";
                }
                else
                {
                    if (Lista.Columns[i].Name.ToUpper() == "codCircuito".ToUpper())
                    {
                        Lista.Columns[i].HeaderText = "CÓDIGO";
                    }
                    else
                    {
                        if (Lista.Columns[i].Name.ToUpper() == "descricao".ToUpper())
                        {
                            Lista.Columns[i].HeaderText = "DESCRIÇÃO";
                            Lista.Columns[i].Width = 300;
                        }
                        else
                        {
                            if (Lista.Columns[i].Name.ToUpper() == "tipoInstalacao".ToUpper())
                            {
                                Lista.Columns[i].HeaderText = "TIPO DE INSTALAÇÃO";
                                Lista.Columns[i].Width = 300;
                            }
                            else
                            {
                                Lista.Columns[i].Visible = false;
                            }
                        }
                    }
                }
            }

            Lista.Columns["idCircuito"].DisplayIndex = 0;
            Lista.Columns["codCircuito"].DisplayIndex = 1;
            Lista.Columns["descricao"].DisplayIndex = 2;
            Lista.Columns["tipoInstalacao"].DisplayIndex = 3;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            OpenFormCadastro();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscaCircuito_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetCircuitoController().isFormBuscaOpened = false;
        }

        private void FormBuscaCircuito_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscaCodigo.Text))
            {
                PreencheGrid(txtBuscaCodigo.Text.ToString());
            }
            else
            {
                PreencheGrid();
            }
        }

        private void txtBuscaCodigo_TextChanged(object sender, EventArgs e)
        {
            txtBuscaCodigo.Text = Helper.Helper.SomenteNumeros(txtBuscaCodigo.Text);
            txtBuscaCodigo.Select(txtBuscaCodigo.Text.Length, 0);
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
                string message = $"Deseja realmente excluir o usuário {Lista.CurrentRow.Cells[1].Value.ToString()}?";
                string caption = "Excluir";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GetCircuitoController().Delete(Convert.ToInt32(Lista.CurrentRow.Cells[0].Value.ToString()));
                    PreencheGrid();
                }
            }
        }
    }
}
