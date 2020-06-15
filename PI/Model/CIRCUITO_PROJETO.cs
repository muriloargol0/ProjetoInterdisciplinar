namespace PI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIRCUITO_PROJETO
    {
        [Key]
        public int ID_CIRCUITO_PROJETO { get; set; }

        public int? ID_PROJETO { get; set; }

        public int? ID_CIRCUITO { get; set; }

        public virtual CIRCUITO CIRCUITO { get; set; }

        public virtual PROJETO PROJETO { get; set; }

        public int ENTRADA { get; set; }
    }
}
