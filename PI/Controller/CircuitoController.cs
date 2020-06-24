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
    public class CircuitoController
    {

        public bool isFormCadastroOpened { get; set; }
        public bool isFormBuscaOpened { get; set; }

        public bool Save(CircuitoDTO dto, out int idCircuito)
        {
            idCircuito = 0;

            using (var ctx = new DBContext())
            {
                //Se não houver ID salva um novo registro
                if (dto.idCircuito == 0)
                {
                    var c = new CIRCUITO();
                    c.ID_STATUS = 1;
                    c.ID_USER = Helper.Helper.GetIdUser();
                    c.OBSERVACAO = dto.observacao.ToUpper();
                    c.DESCRICAO = dto.descricao.ToUpper();
                    c.POTENCIA_APARENTE = dto.potenciaAparente;
                    c.DISJUNTOR_DR = dto.disjuntorDr;
                    c.DR_AMPER = dto.DrAmper;
                    c.DISJUNTOR = dto.disjuntor;
                    c.BITOLA_CABO = dto.bitolaCabo;
                    c.CORRENTE_ALTERNADA = dto.correnteAlternada;
                    c.FATOR_POTENCIA = dto.fatorPotencia;
                    c.POTENCIA_ATIVA = dto.potenciaAtiva;
                    c.TENSAO = dto.tensao;
                    c.COD_CIRCUITO = dto.codCircuito;
                    c.FASES = dto.fases;
                    c.TIPO_INSTALACAO = dto.tipoInstalacao;

                    ctx.CIRCUITO.Add(c);
                    ctx.SaveChanges();
                    idCircuito = ctx.CIRCUITO.OrderBy(ci => ci.ID_CIRCUITO).OrderByDescending(x => x.ID_CIRCUITO).Take(1).FirstOrDefault().ID_CIRCUITO;
                }
                else
                {
                    var id = dto.idCircuito;

                    var query = ctx.CIRCUITO.Single(x => x.ID_CIRCUITO == id);

                    if (query != null)
                    {
                        //query.ID_STATUS = 1;
                        query.ID_USER = Helper.Helper.GetIdUser();
                        query.OBSERVACAO = dto.observacao.ToUpper();
                        query.DESCRICAO = dto.descricao.ToUpper();
                        query.POTENCIA_APARENTE = Convert.ToDecimal(dto.potenciaAparente);
                        query.DISJUNTOR_DR = dto.disjuntorDr;
                        query.DR_AMPER = dto.DrAmper;
                        query.DISJUNTOR = dto.disjuntor;
                        query.BITOLA_CABO = dto.bitolaCabo;
                        query.CORRENTE_ALTERNADA = dto.correnteAlternada;
                        query.FATOR_POTENCIA = dto.fatorPotencia;
                        query.POTENCIA_ATIVA = dto.potenciaAtiva;
                        query.TENSAO = dto.tensao;
                        query.COD_CIRCUITO = dto.codCircuito;
                        query.FASES = dto.fases;
                        query.TIPO_INSTALACAO = dto.tipoInstalacao;

                        idCircuito = id;
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
                var query = ctx.CIRCUITO.Single(x => x.ID_CIRCUITO == Id);

                query.ID_STATUS = 2;
                ctx.SaveChanges();

                return true;
            }
        }
        public List<CircuitoDTO> GetCircuitos(string parametro = "")
        {
            using (var ctx = new DBContext())
            {
                List<CIRCUITO> c = new List<CIRCUITO>();

                List<CircuitoDTO> ListaCircuitos = new List<CircuitoDTO>();

                if (string.IsNullOrEmpty(parametro))
                {
                    c = (from ci in ctx.CIRCUITO
                           where ci.ID_STATUS == 1
                          select ci).ToList();
                }
                else
                {
                    var cod = Convert.ToInt32(parametro);
                    c = (from ci in ctx.CIRCUITO
                           where ci.COD_CIRCUITO == cod && ci.ID_STATUS == 1
                           select ci).ToList();
                }

                if (c != null)
                {
                    foreach (var item in c)
                    {
                        CircuitoDTO ci = new CircuitoDTO();
                        ci.idCircuito = item.ID_CIRCUITO;
                        ci.idStatus = item.ID_STATUS;
                        ci.idUser = item.ID_USER;
                        ci.observacao = item.OBSERVACAO.ToUpper();
                        ci.descricao = item.DESCRICAO.ToUpper();
                        ci.potenciaAparente = item.POTENCIA_APARENTE;
                        ci.disjuntorDr = item.DISJUNTOR_DR;
                        ci.DrAmper = item.DR_AMPER;
                        ci.disjuntor = item.DISJUNTOR;
                        ci.bitolaCabo = item.BITOLA_CABO;
                        ci.correnteAlternada = item.CORRENTE_ALTERNADA;
                        ci.fatorPotencia = item.FATOR_POTENCIA;
                        ci.potenciaAtiva = item.POTENCIA_ATIVA;
                        ci.tensao = item.TENSAO;
                        ci.codCircuito = item.COD_CIRCUITO;
                        ci.fases = item.FASES;
                        ci.tipoInstalacao = item.TIPO_INSTALACAO;
                        ListaCircuitos.Add(ci);
                    }
                }

                return ListaCircuitos;
            }
        }

        public bool ValidaExisteCodCircuito(int cod)
        {
            using (var ctx = new DBContext())
            {

                var query = (from c in ctx.CIRCUITO
                             where c.COD_CIRCUITO == cod
                             select c);

                if (query.Count() > 0)
                    return false;

                return true;
            }
        }
        public string GetBitolaCabo(string tipoInstalacao, int fase, decimal corrente)
        {
            string bitolaCabo = string.Empty;

            using (var ctx = new DBContext())
            {
                bitolaCabo = (from dc in ctx.DIMENSAO_CABO
                              where dc.TIPO_INSTALACAO == tipoInstalacao
                                && dc.FASE == fase
                                && dc.CONDUTORES > corrente
                              select dc).FirstOrDefault().DIAMENTRO_CABO.ToString();
            }
            return bitolaCabo;
        }
    }
}
