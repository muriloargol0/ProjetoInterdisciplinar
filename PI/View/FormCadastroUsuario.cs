using Microsoft.EntityFrameworkCore;
using PI.Controller;
using PI.Database;
using PI.Model.In;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.View
{
    public partial class FormCadastroUsuario : Form
    {
        private UserController _uc = null;

        public UserController GetUserController()
        {
            return _uc;
        }

        public int SetEditId { get; set; }

        public FormCadastroUsuario(UserController uc)
        {
            _uc = uc;
            InitializeComponent();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(((Button)(sender)).Tag) == 0)
            {
                ((Button)(sender)).Tag = 1;
                txtSENHA.PasswordChar = '\u0000';
            }
            else
            {
                ((Button)(sender)).Tag = 0;
                txtSENHA.PasswordChar = '*';
            }   
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helper.Helper.LimparCampos(this.Controls);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            GetUserController().isFormCadastroOpened = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void preencheCampos(USER dto)
        {
            txtID.Text = dto.ID_USER.ToString();
            txtID.Visible = false;
            txtEMAIL.Text = dto.EMAIL.ToString();
            txtLOGIN.Text = dto.LOGIN.ToString();
            txtNOME.Text = dto.NOME.ToString();
            txtSENHA.Text = dto.SENHA.ToString();
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if(SetEditId > 0)
            {
                using (var ctx = new DBContext())
                {
                    var editUsr = ctx.USER.Where(x => x.ID_USER == SetEditId).FirstOrDefault();
                    if (editUsr == null)
                        throw new Exception("O usuário não pode ser editado pois não foi encontrado.");

                    preencheCampos(editUsr);
                }
            }

            if(Helper.Helper.GetIdUser() != 1)
            {
                btnNovo.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                string message = $"Deseja realmente excluir o usuário {txtNOME.Text} ?";
                string caption = "Excluir";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GetUserController().Delete(Convert.ToInt32(txtID.Text));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                Helper.Helper.ShowMessageError("Não é possível excluir um usuário que ainda não foi registrado!", "Erro de Exclusão");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Helper.Helper.ValidaCampos(this.Controls))
            {
                UserDTO dto = new UserDTO();

                dto.idUser = Convert.ToInt32(txtID.Text == "" ? "0" : txtID.Text);
                dto.login = txtLOGIN.Text;
                dto.nome = txtNOME.Text;
                dto.senha = txtSENHA.Text;
                dto.email = txtEMAIL.Text;

                GetUserController().Save(dto, out int IdUser);

                if(string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Usuário alterado com sucesso!");
                }
                

                txtID.Text = IdUser.ToString();
            }
            else
            {
                Helper.Helper.ShowMessageError("Os campos destacados na cor VERMELHA devem ser preenchidos!", "Campos Obrigatórios");
            }
            
        }

        private void txtEMAIL_Leave(object sender, EventArgs e)
        {
            bool existe = false;
            var id = string.IsNullOrEmpty(txtID.Text.ToString()) ? "0" : txtID.Text;

            if (!string.IsNullOrEmpty(txtEMAIL.Text))
                existe = GetUserController().VerificaSeExiste("email", txtEMAIL.Text, Convert.ToInt32(id));
            if (existe)
            {
                txtEMAIL.ForeColor = Color.Yellow;
                Helper.Helper.ShowMessageError("Este e-mail já está em uso!", "Erro de Validação");
                txtEMAIL.Text = string.Empty;
                txtEMAIL.ForeColor = Color.Black;
                txtEMAIL.Focus();
            }
                
        }

        private void txtLOGIN_Leave(object sender, EventArgs e)
        {
            bool existe = false;
            var id = string.IsNullOrEmpty(txtID.Text.ToString()) ? "0" : txtID.Text;

            if (!string.IsNullOrEmpty(txtLOGIN.Text))
                existe = GetUserController().VerificaSeExiste("login", txtLOGIN.Text, Convert.ToInt32(id));

            if (existe)
            {
                txtLOGIN.ForeColor = Color.Yellow;
                Helper.Helper.ShowMessageError("Este login já está em uso!", "Erro de Validação");
                txtLOGIN.Text = string.Empty;
                txtLOGIN.ForeColor = Color.Black;
                txtLOGIN.Focus();
            }
        }

        private void FormCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetUserController().isFormCadastroOpened = false;
        }
    }
}
