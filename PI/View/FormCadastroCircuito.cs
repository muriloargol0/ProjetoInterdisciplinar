using Microsoft.EntityFrameworkCore;
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
        private static bool _opened = false;
        public bool isOpened {
            get {
                return _opened;
            }

            set {
                _opened = true;
            } 
        }
        public FormCadastroCircuito()
        {
            InitializeComponent();
        }

        private void FormCadastroCircuito_FormClosing(object sender, FormClosingEventArgs e)
        {
            _opened = false;
        }

        private void AtualizaPotenciaAparenteECorrente(object sender, EventArgs e)
        {
            int.TryParse(txtPotenciaAparente.Text, out int pa);
            int.TryParse(txtFatorPotencia.Text, out int fp);

        }

        private void txtFatorPotencia_Leave(object sender, EventArgs e)
        {
            MaskedTextBox t = (MaskedTextBox)sender;

            if (Convert.ToDecimal(t.Text) > 1)
            {
                MessageBox.Show("Valor incompatível, por favor digite um número entre 0 e 1");
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
    }
}
