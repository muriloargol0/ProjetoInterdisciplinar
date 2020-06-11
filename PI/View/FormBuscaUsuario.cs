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
    public partial class FormBuscaUsuario : Form
    {
        private UserController _userController;

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
        public FormBuscaUsuario()
        {
            InitializeComponent();
        }

        public UserController GetUserController()
        {
            if (_userController == null)
                _userController = new UserController();

            return _userController;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario uc = new FormCadastroUsuario();

            if (!uc.isOpened)
            {
                uc.isOpened = true;
                uc.MdiParent = this.MdiParent;
                uc.Show();
            }
            else
            {
                MessageBox.Show("Esta janela já está aberta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBuscaUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
