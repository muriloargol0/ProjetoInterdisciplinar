namespace PI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJETO")]
    public partial class PROJETO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJETO()
        {
            CIRCUITO_PROJETO = new HashSet<CIRCUITO_PROJETO>();
        }

        [Key]
        public int ID_PROJETO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public int? ENTRADAS { get; set; }

        public int? ID_USER { get; set; }

        public int? ID_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIRCUITO_PROJETO> CIRCUITO_PROJETO { get; set; }

        public virtual STATUS STATUS { get; set; }

        public virtual USER USER { get; set; }
    }
}
