using PI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.Controller
{
    public class LoginController
    {
        public bool DoLogin(string login, string senha, out string mensagem)
        {
            using (var ctx = new DBContext())
            {
                var usr = (from u in ctx.USER
                           where u.LOGIN == login && u.SENHA == senha && u.ID_STATUS == 1
                           select u).FirstOrDefault();

                if(usr == null)
                {
                    Helper.Helper.ShowMessageError("Usuário e senha incorretos!", "Acesso negado");
                    mensagem = "Usuário e senha incorretos!";
                    return false;
                }

                Helper.Helper.SetUsuarioLogado(usr.ID_USER, usr.LOGIN);

                mensagem = string.Empty;
                return true;
            }
        }
    }
}
