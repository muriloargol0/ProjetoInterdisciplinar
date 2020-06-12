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
    public partial class FormBuscaCircuito : Form
    {
        private static bool _opened = false;
        public bool isOpened
        {
            get
            {
                return _opened;
            }

            set
            {
                _opened = true;
            }
        }
        public FormBuscaCircuito()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroCircuito cc = new FormCadastroCircuito();
            cc.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscaCircuito_FormClosing(object sender, FormClosingEventArgs e)
        {
            _opened = false;
        }
    }
}
