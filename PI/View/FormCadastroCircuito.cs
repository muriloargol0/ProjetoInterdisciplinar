using Microsoft.EntityFrameworkCore;
using PI.Controller;
using PI.Database;
using PI.Model.In;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.View
{
    public partial class FormCadastroCircuito : Form
    {
        private CircuitoController _circuitoController = null;
       

        public FormCadastroCircuito(CircuitoController cc)
        {
            _circuitoController = cc;
            InitializeComponent();
        }

        public CircuitoController GetCircuitoController()
        {
            return _circuitoController;
        }

        public int SetEditId { get; set; }

        private void FormCadastroCircuito_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetCircuitoController().isFormCadastroOpened = false;
        }

        private void AtualizaCorrente(object sender, EventArgs e)
        {
            
            if (txtPotenciaAparente.Text != "    ,")
            {
                if (txtTensao.Text.Length > 0)
                {
                    decimal.TryParse(txtPotenciaAparente.Text, out decimal pa);
                    int.TryParse(txtTensao.Text, out int tensao);

                    var corrente = Convert.ToString(pa / (decimal)tensao);
                    var co = corrente.Substring(corrente.IndexOf(",") + 1, corrente.Length - (corrente.IndexOf(",") + 1));

                    if(co.Length > 2)
                        txtCorrenteAlternada.Text = corrente.Substring(0, corrente.IndexOf(",") + 3);
                }
            }
        }

        private void txtFatorPotencia_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            if (!Helper.Helper.ValidaCasasVirgula(t.Text, 0, 2))
            {
                ((TextBox)(sender)).Text = string.Empty;
            }
            else
            {
                if (!string.IsNullOrEmpty(t.Text))
                {
                    if (Convert.ToDecimal(t.Text) > 1)
                    {
                        Helper.Helper.ShowMessageError("Valor incompatível, por favor digite um número entre 0 e 1", "Erro de validação");
                        t.Text = string.Empty;
                    }
                }

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helper.Helper.LimparCampos(this.Controls);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Helper.Helper.ValidaCampos(this.Controls))
            {
                CircuitoDTO dto = new CircuitoDTO();

                dto.idCircuito = Convert.ToInt32(txtID.Text == "" ? "0" : txtID.Text);
                dto.descricao = txtDescricao.Text;
                dto.potenciaAparente = Convert.ToDecimal(txtPotenciaAparente.Text);
                dto.disjuntorDr = Convert.ToInt32(txtDisjuntorDR.SelectedIndex);
                dto.DrAmper = Convert.ToInt32(txtDRAmper.Text);
                dto.observacao = txtObservacao.Text;
                dto.disjuntor = Convert.ToInt32(txtDisjuntor.Text);
                dto.bitolaCabo = Convert.ToDecimal(txtBitolaCabo.Text);
                dto.correnteAlternada = Convert.ToDecimal(txtCorrenteAlternada.Text);
                dto.fatorPotencia = Convert.ToDecimal(txtFatorPotencia.Text);
                dto.potenciaAtiva = Convert.ToInt32(txtPotenciaAtiva.Text);
                dto.tensao = Convert.ToInt32(txtTensao.Text);
                dto.codCircuito = Convert.ToInt32(txtCodigo.Text);
                dto.fases = Convert.ToInt32(txtFases.Text);
                dto.idStatus = 1;
                dto.idUser = Helper.Helper.GetIdUser();
                dto.tipoInstalacao = txtTipoInstalacao.Text;
                
                //TODO: Preencher o DTO com os valores dos campos da tela
                GetCircuitoController().Save(dto, out int idCircuito);

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Circuito cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Circuito alterado com sucesso!");
                }

                txtID.Text = idCircuito.ToString();
            }
            else
            {
                Helper.Helper.ShowMessageError("Os campos destacados na cor VERMELHA devem ser preenchidos!", "Campos Obrigatórios");
            }
        }

        private void txtTensao_TextChanged(object sender, EventArgs e)
        {
            txtTensao.Text = Helper.Helper.SomenteNumeros(txtTensao.Text);
        }

        private void txtFatorPotencia_TextChanged(object sender, EventArgs e)
        {
            txtFatorPotencia.Text = Helper.Helper.SomenteNumerosEPontos(txtFatorPotencia.Text);
        }

        private void txtDisjuntor_TextChanged(object sender, EventArgs e)
        {
            txtDisjuntor.Text = Helper.Helper.SomenteNumeros(txtDisjuntor.Text);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = Helper.Helper.SomenteNumeros(txtCodigo.Text);
        }

        private void txtPotenciaAtiva_TextChanged(object sender, EventArgs e)
        {
            txtPotenciaAtiva.Text = Helper.Helper.SomenteNumeros(txtPotenciaAtiva.Text);
        }

        private void txtDisjuntorDR_TextChanged(object sender, EventArgs e)
        {
            txtDisjuntorDR.Text = Helper.Helper.SomenteNumeros(txtDisjuntorDR.Text);
        }

        private void txtFases_TextChanged(object sender, EventArgs e)
        {
            txtFases.Text = Helper.Helper.SomenteNumeros(txtFases.Text);

            if (!string.IsNullOrEmpty(txtFases.Text))
            {
                if (Convert.ToInt32(txtFases.Text) < 0 || Convert.ToInt32(txtFases.Text) > 3)
                {
                    Helper.Helper.ShowMessageError("Este campo aceita apenas valores maiores que 0 e menores ou igual a 2", "Valor incompatível");
                }
            }
        }

        private void txtTipoInstalacao_TextChanged(object sender, EventArgs e)
        {
            if(txtTipoInstalacao.SelectedIndex > 0)
            {
                if(!string.IsNullOrEmpty(txtTipoInstalacao.Text) && !string.IsNullOrEmpty(txtFases.Text) && !string.IsNullOrEmpty(txtCorrenteAlternada.Text))
                {
                    //Se a fase for 3, o diametro do cabo é o mesmo que o 2
                    var fase = Convert.ToInt32(txtFases.Text); 
                    txtBitolaCabo.Text = GetCircuitoController().GetBitolaCabo(txtTipoInstalacao.Text, fase == 3 ? 2 : fase, Convert.ToDecimal(txtCorrenteAlternada.Text));
                }
            }
        }

        private void txtPotenciaAparente_Enter(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPotenciaAtiva.Text) && !string.IsNullOrEmpty(txtFatorPotencia.Text))
            {
                int.TryParse(txtPotenciaAtiva.Text, out int pa);
                decimal.TryParse(txtFatorPotencia.Text, out decimal fp);

                txtPotenciaAparente.Text = Convert.ToString(pa / (decimal)fp);
            }
        }

        private void lblFases_Click(object sender, EventArgs e)
        {

        }

        private void preencheCampos(CIRCUITO dto)
        {
            txtID.Text = dto.ID_CIRCUITO.ToString();
            txtID.Visible = false;
            txtBitolaCabo.Text = dto.BITOLA_CABO.ToString();
            txtCodigo.Text = dto.COD_CIRCUITO.ToString();
            txtCorrenteAlternada.Text = dto.CORRENTE_ALTERNADA.ToString();
            txtDescricao.Text = dto.DESCRICAO.ToUpper();
            txtDisjuntor.Text = dto.DISJUNTOR.ToString();
            txtDisjuntorDR.SelectedIndex = Convert.ToInt32(dto.DISJUNTOR_DR);
            txtDRAmper.Text = dto.DR_AMPER.ToString();
            txtFases.Text = dto.FASES.ToString();
            txtFatorPotencia.Text = dto.FATOR_POTENCIA.ToString();
            txtObservacao.Text = dto.OBSERVACAO.ToUpper();
            txtPotenciaAparente.Text = dto.POTENCIA_APARENTE.ToString();
            txtPotenciaAtiva.Text = dto.POTENCIA_ATIVA.ToString();
            txtTensao.Text = dto.TENSAO.ToString();
            txtTipoInstalacao.Text = dto.TIPO_INSTALACAO.ToUpper();
        }

        private void FormCadastroCircuito_Load(object sender, EventArgs e)
        {
            if (SetEditId > 0)
            {
                using (var ctx = new DBContext())
                {
                    var edit = ctx.CIRCUITO.Where(x => x.ID_CIRCUITO == SetEditId).FirstOrDefault();
                    if (edit == null)
                        throw new Exception("O circuito não pode ser editado pois não foi encontrado.");

                    preencheCampos(edit);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                string message = $"Deseja realmente excluir o circuito {txtDescricao.Text} ?";
                string caption = "Excluir";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GetCircuitoController().Delete(Convert.ToInt32(txtID.Text));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                Helper.Helper.ShowMessageError("Não é possível excluir um circuito que ainda não foi registrado!", "Erro de Exclusão");
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    if (!GetCircuitoController().ValidaExisteCodCircuito(Convert.ToInt32(txtCodigo.Text)))
                    {
                        Helper.Helper.ShowMessageError("Já existe um circuito cadastrado com esse código!", "Erro de Validação");
                        txtCodigo.Text = string.Empty;
                        txtCodigo.Focus();
                    }
                }
            }
        }

        private void txtDisjuntorDR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtDisjuntorDR.Text == "NÃO")
            {
                txtDRAmper.ReadOnly = true;
                txtDRAmper.Text = "0";
            }
            else
            {
                txtDRAmper.ReadOnly = false;
            }
        }
    }
}
