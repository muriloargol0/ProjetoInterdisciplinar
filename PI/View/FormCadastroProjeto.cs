using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PI.Controller;
using PI.Database;
using PI.Model.In;
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
        List<CircuitoProjetoDTO> _cpDTO = null;
        CircuitoDTO _circuitoDTO = null;

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

        private List<CircuitoProjetoDTO> GetListCircuitoProjetoDTO()
        {
            if (_cpDTO == null)
                _cpDTO = new List<CircuitoProjetoDTO>();

            return _cpDTO;
        }

        private int GetEntradaBalanceada(int? correnteDisjuntor)
        {
            //TODO: fazer o calculo e verificar qual a melhor entrada para esse circuito ser inserido
            return 1;
        }


        private void btnAdicionarCircuito_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodigoCircuito.Text) && !string.IsNullOrEmpty(txtDescricaoCircuito.Text))
            {
                Lista.Rows.Add(txtCodigoCircuito.Text, txtDescricaoCircuito.Text, GetUltimoCircuitoAdicionado().disjuntor,"1");
                txtCodigoCircuito.Focus();             

                CircuitoProjetoDTO cp = new CircuitoProjetoDTO();
                cp.idCircuito = Convert.ToInt32(GetUltimoCircuitoAdicionado().idCircuito);
                cp.descricaoCircuito = GetUltimoCircuitoAdicionado().descricao;
                cp.correnteDisjuntor = GetUltimoCircuitoAdicionado().disjuntor;
                cp.entrada = GetEntradaBalanceada(cp.correnteDisjuntor);

                //Adiciona o circuito na lista que será utilizada para salvar no banco
                GetListCircuitoProjetoDTO().Add(cp);
            }
            else
            {
                Helper.Helper.ShowMessageError("Nenhum circuito selecionado!", "Circuito inválido");
                txtCodigoCircuito.Focus();
            }
        }

        private void txtDescricaoProjeto_TextChanged(object sender, EventArgs e)
        {
            txtDescricaoProjeto.Text = Helper.Helper.SomenteCaracteres(txtDescricaoProjeto.Text);
        }

        private void txtEntradas_TextChanged(object sender, EventArgs e)
        {
            txtEntradas.Text = Helper.Helper.SomenteNumeros(txtEntradas.Text);

            if (!string.IsNullOrEmpty(txtEntradas.Text))
            {
                if (Convert.ToInt32(txtEntradas.Text) < 1 || Convert.ToInt32(txtEntradas.Text) > 3)
                {
                    Helper.Helper.ShowMessageError("Valor inválido, este campo aceita apenas valores de 1 até 3!", "Valor incompatível");
                    txtEntradas.Text = string.Empty;
                    txtCodigoCircuito.ReadOnly = true;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCodigoCircuito.Text))
                    {
                        txtCodigoCircuito.ReadOnly = false;
                    }
                    else
                    {
                        txtCodigoCircuito.ReadOnly = true;
                    }
                }
            }
        }

        private void SetUltimoCircuitoAdicionado(CircuitoDTO c)
        {
            _circuitoDTO = c;
        }

        private CircuitoDTO GetUltimoCircuitoAdicionado()
        {
            return _circuitoDTO;
        }

        private void txtCodigoCircuito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                var c = GetProjetoController().GetCircuito(txtCodigoCircuito.Text);
                if (c.idCircuito > 0)
                { 
                    txtDescricaoCircuito.Text = c.descricao;
                    btnAdicionarCircuito.Focus();
                    SetUltimoCircuitoAdicionado(c);
                }
                else
                {
                    Helper.Helper.ShowMessageError("Circuito não encontrado!", "Erro ao buscar circuito");
                    txtCodigoCircuito.Text = string.Empty;
                    txtDescricaoCircuito.Text = string.Empty;
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
