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
                toolUser.Text = Helper.Helper.GetLoginUser();
                toolData.Text = string.Format(DateTime.Now.ToShortDateString(), CultureInfo.InvariantCulture);
            }
            else
            {
                this.Close();
            }
        }

        private void FormContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Helper.Helper.GetIdUser() > 0)
            {
                const string message = "Deseja realmente sair da aplicação?";
                const string caption = "Sair da Aplicação";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
