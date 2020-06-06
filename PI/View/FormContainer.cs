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
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.MdiParent = this;
            m.Show();
        }
    }
}
