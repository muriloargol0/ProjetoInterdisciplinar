namespace PI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public partial class DIMENSAO_CABO
    {
        [Key]
        public int ID_DIMENSAO_CABO { get; set; }

        public decimal DIAMENTRO_CABO { get; set; }

        [Required]
        [StringLength(10)]
        public string TIPO_INSTALACAO { get; set; }

        public int FASE { get; set; }

        public int CONDUTORES { get; set; }
    }
}
