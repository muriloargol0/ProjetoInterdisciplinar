namespace PI.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CIRCUITO")]
    public partial class CIRCUITO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIRCUITO()
        {
            CIRCUITO_PROJETO = new HashSet<CIRCUITO_PROJETO>();
        }

        [Key]
        public int ID_CIRCUITO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public decimal? POTENCIA_APARENTE { get; set; }

        public int? DISJUNTOR_DR { get; set; }

        public int? DR_AMPER { get; set; }

        [StringLength(150)]
        public string OBSERVACAO { get; set; }

        public int? DISJUNTOR { get; set; }

        public decimal? BITOLA_CABO { get; set; }

        public decimal? CORRENTE_ALTERNADA { get; set; }

        public decimal? FATOR_POTENCIA { get; set; }

        public int? POTENCIA_ATIVA { get; set; }

        public int? TENSAO { get; set; }

        public int? COD_CIRCUITO { get; set; }

        public int? FASES { get; set; }

        public int? ID_STATUS { get; set; }

        public string TIPO_INSTALACAO { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        public int? ID_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIRCUITO_PROJETO> CIRCUITO_PROJETO { get; set; }

        public virtual STATUS STATUS { get; set; }

        public virtual USER USER { get; set; }
    }
}
