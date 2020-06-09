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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrarCircuito_Click(object sender, EventArgs e)
        {
            FormCadastroCircuito cc = new FormCadastroCircuito();
            if (!cc.isOpened)
            {
                cc.isOpened = true;
                cc.MdiParent = this.MdiParent;
                cc.Show();
            }
            else
            {
                MessageBox.Show("A tela já está aberta.");
            }
                
        }
    }
}
