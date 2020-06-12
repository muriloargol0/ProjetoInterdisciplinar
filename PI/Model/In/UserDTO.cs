using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Model.In
{
    public class UserDTO
    {
        public int idUser { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int? id_status { get; set; }
    }
}
