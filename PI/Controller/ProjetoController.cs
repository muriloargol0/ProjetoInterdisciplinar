using PI.Database;
using PI.Model.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Controller
{
    public class ProjetoController
    {
        public bool isFormCadastroOpened { get; set; }
        public bool isFormBuscaOpened { get; set; }

        public bool Save(ProjetoDTO dto, out int idProjeto)
        {
            idProjeto = 0;

            using (var ctx = new DBContext())
            {
                //Se não houver ID salva um novo registro
                if (dto.idProjeto == 0)
                {
                    var p = new PROJETO();
                    p.ID_STATUS = 1;
                    p.DESCRICAO = dto.descricao.ToUpper();
                    p.ENTRADAS = dto.entradas;
                    p.ID_USER = Helper.Helper.GetIdUser();
                    

                    ctx.PROJETO.Add(p);
                    ctx.SaveChanges();

                    idProjeto = ctx.PROJETO.OrderBy(pt => pt.ID_PROJETO).OrderByDescending(x => x.ID_PROJETO).Take(1).FirstOrDefault().ID_PROJETO;
                }
                else
                {
                    var id = dto.idProjeto;

                    var query = ctx.PROJETO.Single(x => x.ID_PROJETO == id);

                    if (query != null)
                    {
                        //query.ID_STATUS = 1;
                        query.DESCRICAO = dto.descricao.ToUpper();
                        query.ENTRADAS = dto.entradas;

                        idProjeto = id;
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
        public List<ProjetoDTO> GetProjetos(string parametro = "")
        {
            using (var ctx = new DBContext())
            {
                List<PROJETO> usr = null;

                List<ProjetoDTO> ListaProjetos = new List<ProjetoDTO>();

                if (string.IsNullOrEmpty(parametro))
                {
                    usr = (from p in ctx.PROJETO
                           where p.ID_STATUS == 1
                           select p).ToList();
                }
                else
                {
                    usr = (from p in ctx.PROJETO
                           where p.DESCRICAO == parametro && p.ID_STATUS == 1
                           select p).ToList();
                }

                if (usr != null)
                {
                    foreach (var item in usr)
                    {
                        ProjetoDTO p = new ProjetoDTO();
                        p.idProjeto = item.ID_PROJETO;
                        p.descricao = item.DESCRICAO;
                        p.entradas = item.ENTRADAS;
                        p.idStatus = item.ID_STATUS;
                        p.idUser = item.ID_USER;
                        ListaProjetos.Add(p);
                    }
                }

                return ListaProjetos;
            }
        }

        public bool VerificaSeExiste(string name, string value, int ID)
        {
            using (var ctx = new DBContext())
            {
                PROJETO query = null;

                if (name == "descricao")
                {
                    query = ctx.PROJETO.Where(x => x.DESCRICAO == value).FirstOrDefault();

                    if (query == null)
                        return false;

                    //Se não cair no reuturn acima, retorna true
                    return true;
                }
            }
            return false;
        }
    }
}
