using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Model.In
{
    public class CircuitoProjetoDTO
    {
        public int? idCircuitoProjeto { get; set; }
        public int? idCircuito { get; set; }
        public string descricaoCircuito { get; set; }
        public int? entrada { get; set; }
        public int? correnteDisjuntor { get; set; }
    }
}
