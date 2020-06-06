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
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {

            toolUser.Text = "Administrador";
            toolData.Text = string.Format(DateTime.Now.ToShortDateString(), CultureInfo.InvariantCulture);

            Menu m = new Menu();
            m.MdiParent = this;
            m.Show();
        }

        private void FormContainer_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            Login l = new Login();
            l.ShowDialog();

            if(l.DialogResult == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();
            }
        }
    }
}
