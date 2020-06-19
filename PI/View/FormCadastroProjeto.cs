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

    }
}
