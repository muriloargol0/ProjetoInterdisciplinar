using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Reporting.WinForms;
using PI.Controller;
using PI.Database;
using PI.Model.In;
using PI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            int? entrada1 = 0;
            int? entrada2 = 0;
            int? entrada3 = 0;
            int entradaFinal = 0;

            entrada1 = GetListCircuitoProjetoDTO().Where(x => x.entrada == 1).Select(x => x.correnteDisjuntor).Sum();
            entrada2 = GetListCircuitoProjetoDTO().Where(x => x.entrada == 2).Select(x => x.correnteDisjuntor).Sum();
            entrada3 = GetListCircuitoProjetoDTO().Where(x => x.entrada == 3).Select(x => x.correnteDisjuntor).Sum();

            if (entrada1 == 0) 
                return 1;
            if (entrada2 == 0)
                return 2;

            if (Convert.ToInt32(txtEntradas.Text) == 2)
            {
                if (((entrada1 + correnteDisjuntor) <= (entrada2 + correnteDisjuntor)))
                {
                    entradaFinal = 1;

                }

                if (((entrada2 + correnteDisjuntor) <= (entrada1 + correnteDisjuntor)))
                {
                    entradaFinal = 2;
                }

                if (entrada1 == entrada2)
                {
                    entradaFinal = 1;
                }
            }

            if (Convert.ToInt32(txtEntradas.Text) == 3)
            {
                if (entrada3 == 0)
                    return 3;
            

               if(((entrada1 + correnteDisjuntor) <= (entrada2 + correnteDisjuntor)) && ((entrada1 + correnteDisjuntor) <= (entrada3 + correnteDisjuntor)))
                {
                    entradaFinal = 1;

                }

                if (((entrada2 + correnteDisjuntor) <= (entrada1 + correnteDisjuntor)) && ((entrada2 + correnteDisjuntor) <= (entrada3 + correnteDisjuntor)))
                {
                    entradaFinal = 2;
                }

                if (((entrada3 + correnteDisjuntor) <= (entrada1 + correnteDisjuntor)) && ((entrada3 + correnteDisjuntor) <= (entrada2 + correnteDisjuntor)))
                {
                    entradaFinal = 3;
                }

                if(entrada1 == entrada2 && entrada2 == entrada3)
                {
                    entradaFinal = 1;
                }
            }

            return entradaFinal;
        }


        private void btnAdicionarCircuito_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodigoCircuito.Text) && !string.IsNullOrEmpty(txtDescricaoCircuito.Text))
            {
                //Adiciona os itens na lista
                CircuitoProjetoDTO cp = new CircuitoProjetoDTO();
                cp.idCircuito = Convert.ToInt32(GetUltimoCircuitoAdicionado().idCircuito);
                cp.descricaoCircuito = GetUltimoCircuitoAdicionado().descricao;
                cp.correnteDisjuntor = GetUltimoCircuitoAdicionado().disjuntor;
                cp.entrada = GetEntradaBalanceada(cp.correnteDisjuntor);

                //Adiciona o circuito na lista que será utilizada para salvar no banco
                GetListCircuitoProjetoDTO().Add(cp);

                //Adiciona os itens no grid
                Lista.Rows.Add(txtCodigoCircuito.Text, txtDescricaoCircuito.Text, GetUltimoCircuitoAdicionado().disjuntor, cp.entrada);
                txtCodigoCircuito.Focus();
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
                if (Convert.ToInt32(txtEntradas.Text) <= 1 || Convert.ToInt32(txtEntradas.Text) > 3)
                {
                    Helper.Helper.ShowMessageError("Valor inválido, este campo aceita apenas valores de 2 ou 3!", "Valor incompatível");
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
            this.DialogResult = DialogResult.OK;
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
                    GetListCircuitoProjetoDTO().RemoveAt(Lista.CurrentRow.Index);
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
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                string message = $"Deseja realmente excluir o circuito {txtDescricaoProjeto.Text} ?";
                string caption = "Excluir";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GetProjetoController().Delete(Convert.ToInt32(txtID.Text));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                Helper.Helper.ShowMessageError("Não é possível excluir um circuito que ainda não foi registrado!", "Erro de Exclusão");
            }
        }

        private void btnBalancemento_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Helper.Helper.ValidaCampos(this.Controls))
            {
                ProjetoDTO p = new ProjetoDTO();

                p.idProjeto = Convert.ToInt32(txtID.Text == "" ? "0" : txtID.Text);
                p.descricao = txtDescricaoProjeto.Text;
                p.entradas = Convert.ToInt32(txtEntradas.Text);
                p.idUser = Helper.Helper.GetIdUser();
                p.idStatus = 1;

                GetProjetoController().Save(p, out int id_projeto, GetListCircuitoProjetoDTO());

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Projeto cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Projeto alterado com sucesso!");
                }

                txtID.Text = id_projeto.ToString();
            }
            else
            {
                Helper.Helper.ShowMessageError("Os campos destacados na cor VERMELHA devem ser preenchidos!", "Campos Obrigatórios");
            }
        }

        private void FormCadastroProjeto_Load(object sender, EventArgs e)
        {
            if (SetEditId > 0)
            {
                txtEntradas.ReadOnly = true;

                using (var ctx = new DBContext())
                {
                    var edit = ctx.PROJETO.Where(x => x.ID_PROJETO == SetEditId).FirstOrDefault();
                    if (edit == null)
                        throw new Exception("O circuito não pode ser editado pois não foi encontrado.");

                    preencheCampos(edit);
                }
            }
        }

        private void preencheCampos(PROJETO edit)
        {
            txtDescricaoProjeto.Text = edit.DESCRICAO;
            txtEntradas.Text = edit.ENTRADAS.ToString();
            txtID.Text = edit.ID_PROJETO.ToString();

            //Preencher o grid de itens
            using (var ctx = new DBContext())
            {
                var itens = (from c in ctx.CIRCUITO_PROJETO
                             join ci in ctx.CIRCUITO on c.ID_CIRCUITO equals ci.ID_CIRCUITO
                             where c.ID_PROJETO == edit.ID_PROJETO
                             select new { c.ID_CIRCUITO, c.ID_CIRCUITO_PROJETO, c.ID_PROJETO, c.ENTRADA, ci.DESCRICAO, ci.DISJUNTOR, ci.COD_CIRCUITO }).ToList();

                if (itens.Count > 0)
                {
                    foreach (var item in itens)
                    {
                        //Adiciona os itens na lista
                        CircuitoProjetoDTO cp = new CircuitoProjetoDTO();
                        cp.idCircuito = item.ID_CIRCUITO;
                        cp.descricaoCircuito = item.DESCRICAO;
                        cp.correnteDisjuntor = item.DISJUNTOR;
                        cp.entrada = item.ENTRADA;

                        //Adiciona o circuito na lista que será utilizada para salvar no banco
                        GetListCircuitoProjetoDTO().Add(cp);

                        //adiciona os valores no grid
                        Lista.Rows.Add(item.COD_CIRCUITO, item.DESCRICAO, item.DISJUNTOR, item.ENTRADA);
                    }
                }

                txtCodigoCircuito.Focus();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helper.Helper.LimparCampos(this.Controls);
            Lista.Rows.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                ReportProjeto rp = new ReportProjeto();
                rp.idProjeto = Convert.ToInt32(txtID.Text);
                rp.Show();

            }
            else
            {
                Helper.Helper.ShowMessageError("Para imprimir o projeto é preciso salvá-lo!", "Erro de impressão");
            }
        }
    }
}
