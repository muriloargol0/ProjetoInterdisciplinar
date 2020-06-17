using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PI.Model.In
{
    public class CircuitoDTO
    {
		public int idCircuito { get; set; }
		public string descricao { get; set; }
		public decimal? potenciaAparente { get; set; }
		public int? disjuntorDr { get; set; }
		public int? DrAmper { get; set; }
		public string observacao { get; set; }
		public int? disjuntor { get; set; }
		public decimal? bitolaCabo { get; set; }
		public decimal? correnteAlternada { get; set; }
		public decimal? fatorPotencia { get; set; }
		public int? potenciaAtiva { get; set; }
		public int? tensao { get; set; }
		public int? codCircuito { get; set; }
		public int? fases { get; set; }
		public int? idStatus { get; set; }
		public int? idUser { get; set; }
		public string tipoInstalacao { get; set; }
	}
}
