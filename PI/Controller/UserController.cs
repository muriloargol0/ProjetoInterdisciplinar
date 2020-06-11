using PI.Database;
using PI.Model.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PI.Controller
{
    public class UserController
    {
        public List<UserDTO> GetUsuarios(string parametro = "")
        {
            using (var ctx = new DBContext())
            {
                List<USER> usr = null;

                List<UserDTO> ListaUsuarios = new List<UserDTO>();

                if (!string.IsNullOrEmpty(parametro))
                {
                    usr = (from user in ctx.USER
                           select user).ToList();
                }
                else
                {
                    usr = (from user in ctx.USER
                           where user.LOGIN == parametro
                           select user).ToList();
                }

                if (usr != null)
                {
                    foreach (var item in usr)
                    {
                        UserDTO u = new UserDTO();
                        u.idUser = item.ID_USER;
                        u.nome = item.NOME;
                        u.email = item.EMAIL;
                        u.login = item.LOGIN;
                        u.senha = item.SENHA;
                        u.id_status = item.ID_STATUS;

                        ListaUsuarios.Add(u);
                    }
                }

                return ListaUsuarios;
            }
        }
    }
}
