namespace PI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            PROJETO = new HashSet<PROJETO>();
        }

        [Key]
        public int ID_USER { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string LOGIN { get; set; }

        [StringLength(8)]
        public string SENHA { get; set; }

        public int? ID_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJETO> PROJETO { get; set; }

        public virtual ICollection<CIRCUITO> CIRCUITO { get; set; }

        public virtual STATUS STATUS { get; set; }
    }
}
