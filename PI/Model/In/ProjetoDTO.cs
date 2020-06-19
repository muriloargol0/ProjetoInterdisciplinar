using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Model.In
{
    public class ProjetoDTO
    {
        public int idProjeto { get; set; }

        public string descricao { get; set; }

        public int? entradas { get; set; }

        public int? idUser { get; set; }

        public int? idStatus { get; set; }
    }
}
