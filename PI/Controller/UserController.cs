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

        public bool isFormCadastroOpened { get; set; }
        public bool isFormBuscaOpened { get; set; }

        public bool Save(UserDTO dto, out int idUser)
        {
            idUser = 0;

            using (var ctx = new DBContext())
            {
                //Se não houver ID salva um novo registro
                if (dto.idUser == 0)
                {
                    var user = new USER();
                    user.ID_STATUS = 1;
                    user.LOGIN = dto.login.ToUpper();
                    user.NOME = dto.nome.ToUpper();
                    user.SENHA = dto.senha.ToUpper();
                    user.EMAIL = dto.email.ToUpper();

                    ctx.USER.Add(user);
                    ctx.SaveChanges();
                    idUser = ctx.USER.OrderBy(u => u.ID_USER).OrderByDescending(x => x.ID_USER).Take(1).FirstOrDefault().ID_USER;
                }
                else
                {
                    var id = dto.idUser;

                    var query = ctx.USER.Single(x => x.ID_USER == id);

                    if (query != null)
                    {
                        //query.ID_STATUS = 1;
                        query.LOGIN = dto.login.ToUpper();
                        query.NOME = dto.nome.ToUpper();
                        query.SENHA = dto.senha.ToUpper();
                        query.EMAIL = dto.email.ToUpper();

                        idUser = id;
                        //ctx.USER.Attach(query);
                        ctx.SaveChanges();
                    }
                }
            }

            return true;
        }

        public bool Delete(int Id)
        {
            using (var ctx = new DBContext())
            {
                var query = ctx.USER.Single(x => x.ID_USER == Id);
                
                query.ID_STATUS = 2;
                ctx.SaveChanges();

                return true;
            }
        }
        public List<UserDTO> GetUsuarios(string parametro = "")
        {
            using (var ctx = new DBContext())
            {
                List<USER> usr = null;

                List<UserDTO> ListaUsuarios = new List<UserDTO>();

                if (string.IsNullOrEmpty(parametro))
                {
                    usr = (from user in ctx.USER
                           where user.ID_STATUS == 1
                           select user).ToList();
                }
                else
                {
                    usr = (from user in ctx.USER
                           where user.LOGIN.Contains(parametro) && user.ID_STATUS == 1
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

        public bool VerificaSeExiste(string name, string value, int ID)
        {
            using (var ctx = new DBContext())
            {
                USER query = null;

                if(name == "email")
                {
                    query = ctx.USER.Where(x => x.EMAIL == value).FirstOrDefault();

                    if (query == null)
                        return false;

                    if(query.ID_USER != ID)
                    {
                        if (!string.IsNullOrEmpty(query.EMAIL.ToString()))
                            return true;
                    }
                }

                if(name == "login")
                {
                    query = ctx.USER.Where(x => x.LOGIN == value).FirstOrDefault();

                    if (query == null)
                        return false;

                    if (query.ID_USER != ID)
                    {
                        if (!string.IsNullOrEmpty(query.LOGIN.ToString()))
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
