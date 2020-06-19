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
            //TODO: Listar o circuito no gride + a entrada que ele pertence
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

            }
        }
    }
}
