using PI.Database;
using PI.Model.In;
using System;
using System.Collections;
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

        public bool Save(ProjetoDTO dto, out int idProjeto, List<CircuitoProjetoDTO> listaCircuito)
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

                SaveCircuitoProjeto(idProjeto, listaCircuito);
            }
            return true;
        }

        public void SaveCircuitoProjeto(int idProjeto, List<CircuitoProjetoDTO> listaCircuito)
        {
            using (var ctx = new DBContext())
            {
                var query = (from c in ctx.CIRCUITO_PROJETO
                             where c.ID_PROJETO == idProjeto
                             select c).ToList();

                //Se existirem circuitos adicionados ao projeto, ele remove todos e adiciona novamente
                if(query.Count > 0)
                {
                    foreach (var item in query)
                    {
                        ctx.CIRCUITO_PROJETO.Remove(item);
                    }
                }

                foreach (var item in listaCircuito)
                {
                    CIRCUITO_PROJETO cp = new CIRCUITO_PROJETO();
                    cp.ID_PROJETO = idProjeto;
                    cp.ID_CIRCUITO = item.idCircuito;
                    cp.ENTRADA = Convert.ToInt32(item.entrada);

                    ctx.CIRCUITO_PROJETO.Add(cp);
                    ctx.SaveChanges();
                }  
            }
        }

        public bool Delete(int Id)
        {
            using (var ctx = new DBContext())
            {
                var query = ctx.PROJETO.Single(x => x.ID_PROJETO == Id);

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
                           where p.DESCRICAO.Contains(parametro) && p.ID_STATUS == 1
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

        public CircuitoDTO GetCircuito(string cod)
        {
            int codigo = Convert.ToInt32(cod);

            CircuitoDTO dto = new CircuitoDTO();

            using (var ctx = new DBContext())
            {
                var query = (from c in ctx.CIRCUITO
                             where c.COD_CIRCUITO == codigo && c.ID_STATUS == 1
                             select c).FirstOrDefault();

                if(query != null)
                {
                    dto.bitolaCabo = query.BITOLA_CABO;
                    dto.codCircuito = query.COD_CIRCUITO;
                    dto.correnteAlternada = query.CORRENTE_ALTERNADA;
                    dto.descricao = query.DESCRICAO;
                    dto.disjuntor = query.DISJUNTOR;
                    dto.disjuntorDr = query.DISJUNTOR_DR;
                    dto.DrAmper = query.DR_AMPER;
                    dto.fases = query.FASES;
                    dto.fatorPotencia = query.FATOR_POTENCIA;
                    dto.idCircuito = query.ID_CIRCUITO;
                    dto.idStatus = query.ID_STATUS;
                    dto.idUser = query.ID_USER;
                    dto.observacao = query.OBSERVACAO;
                    dto.potenciaAparente = query.POTENCIA_APARENTE;
                    dto.potenciaAtiva = query.POTENCIA_ATIVA;
                    dto.tensao = query.TENSAO;
                    dto.tipoInstalacao = query.TIPO_INSTALACAO;
                }
            }
            return dto;
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
