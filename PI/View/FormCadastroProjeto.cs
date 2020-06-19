using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FormCadastroProjeto : Form
    {
        ProjetoController _pc = null;
        public FormCadastroProjeto(ProjetoController pc)
        {
            _pc = pc;
            InitializeComponent();
        }

        public int SetEditId { get; set; }

        public ProjetoController GetProjetoController()
        {
            return _pc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodigoCircuito.Text) && !string.IsNullOrEmpty(txtDescricaoCircuito.Text))
            {
                Lista.Rows.Add(txtCodigoCircuito.Text, txtDescricaoCircuito.Text, "1");
            }
            else
            {
                Helper.Helper.ShowMessageError("Nenhum circuito selecionado!", "Circuito inválido");
                txtCodigoCircuito.Focus();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Helper.Helper.SomenteCaracteres(txtCodigo.Text);
        }

        private void txtEntradas_TextChanged(object sender, EventArgs e)
        {
            Helper.Helper.SomenteNumeros(txtEntradas.Text);
        }

        private void txtCodigoCircuito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                var c = GetProjetoController().GetCircuito(txtCodigoCircuito.Text);
                if (c.idCircuito > 0)
                { 
                    txtDescricaoCircuito.Text = c.descricao;
                }
                else
                {
                    Helper.Helper.ShowMessageError("Circuito não encontrado!", "Erro ao buscar circuito");
                    txtCodigoCircuito.Text = string.Empty;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetProjetoController().isFormCadastroOpened = false;
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if(Lista.Rows.Count > 0)
            {
                string message = $"Deseja realmente remover o circuito {Lista.CurrentRow.Cells[1].Value.ToString()} da linha {Lista.CurrentRow.Index + 1}?";
                string caption = "Excluir";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Lista.Rows.RemoveAt(Lista.CurrentRow.Index);
                }
            }
            else
            {
                Helper.Helper.ShowMessageError("Nenhuma linha selecionada para remoção!", "Erro ao remover item");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
