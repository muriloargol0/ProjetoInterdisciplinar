using Microsoft.EntityFrameworkCore;
using PI.Controller;
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

        private void AtualizaPotenciaAparenteECorrente(object sender, EventArgs e)
        {
            if (txtPotenciaAparente.Text != "    ,")
            {
                if (txtTensao.Text.Length > 0)
                {
                    decimal.TryParse(txtPotenciaAparente.Text, out decimal pa);
                    int.TryParse(txtTensao.Text, out int tensao);

                    txtCorrenteAlternada.Text = string.Format("00,0", Convert.ToString(pa / (decimal)tensao));
                }
            }
        }

        private void txtFatorPotencia_Leave(object sender, EventArgs e)
        {
            MaskedTextBox t = (MaskedTextBox)sender;

            if (Convert.ToDecimal(t.Text) > 1)
            {
                Helper.Helper.ShowMessageError("Valor incompatível, por favor digite um número entre 0 e 1", "Erro de validação");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helper.Helper.LimparCampos(this.Controls);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Helper.Helper.ValidaCampos(this.Controls))
            {
                CircuitoDTO dto = new CircuitoDTO();

                //TODO: Preencher o DTO com os valores dos campos da tela
                GetCircuitoController().Save(dto, out int idCircuito);

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
    }
}
