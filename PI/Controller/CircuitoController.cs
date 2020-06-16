using PI.Database;
using PI.Model.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Controller
{
    class CircuitoController
    {

        public bool isFormCadastroOpened { get; set; }
        public bool isFormBuscaOpened { get; set; }

        public bool Save(CircuitoDTO dto, out int idCircuito)
        {
            idCircuito = 0;

            using (var ctx = new DBContext())
            {
                //Se não houver ID salva um novo registro
                if (dto.idUser == 0)
                {
                    var c = new CIRCUITO();
                    c.ID_STATUS = 1;
                    c.ID_USER = Helper.Helper.GetIdUser();
                    c.OBSERVACAO = dto.observacao.ToUpper();
                    c.DESCRICAO = dto.descricao.ToUpper();
                    c.POTENCIA_APARENTE = Convert.ToDecimal(dto.potenciaAparente);
                    c.DISJUNTOR_DR = dto.disjuntorDr;
                    c.DR_AMPER = dto.DrAmper;
                    c.DISJUNTOR = dto.disjuntor;
                    c.BITOLA_CABO = Convert.ToDecimal(dto.bitolaCabo);
                    c.CORRENTE_ALTERNADA = Convert.ToDecimal(dto.correnteAlternada);
                    c.FATOR_POTENCIA = Convert.ToDecimal(dto.fatorPotencia);
                    c.POTENCIA_ATIVA = dto.potenciaAtiva;
                    c.TENSAO = dto.tensao;
                    c.COD_CIRCUITO = dto.codCircuito;
                    c.FASES = dto.fases;

                    ctx.CIRCUITO.Add(c);
                    ctx.SaveChanges();
                    idCircuito = ctx.CIRCUITO.OrderBy(c => c.ID_CIRCUITO).OrderByDescending(x => x.ID_CIRCUITO).Take(1).FirstOrDefault().ID_CIRCUITO;
                }
                else
                {
                    //var id = dto.idUser;

                    //var query = ctx.USER.Single(x => x.ID_USER == id);

                    //if (query != null)
                    //{
                    //    query.ID_STATUS = 1;
                    //    query.LOGIN = dto.login.ToUpper();
                    //    query.NOME = dto.nome.ToUpper();
                    //    query.SENHA = dto.senha.ToUpper();
                    //    query.EMAIL = dto.email.ToUpper();

                    //    idCircuito = id;
                    //    //ctx.USER.Attach(query);
                    //    ctx.SaveChanges();
                    //}
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
    }
}
