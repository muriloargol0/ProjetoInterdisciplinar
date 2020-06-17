namespace PI.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<CIRCUITO> CIRCUITO { get; set; }
        public virtual DbSet<CIRCUITO_PROJETO> CIRCUITO_PROJETO { get; set; }
        public virtual DbSet<PROJETO> PROJETO { get; set; }
        public virtual DbSet<STATUS> STATUS { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<DIMENSAO_CABO> DIMENSAO_CABO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.TIPO_INSTALACAO)
                .IsUnicode(false);
            
            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.POTENCIA_APARENTE)
                .HasPrecision(8, 2);

            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.BITOLA_CABO)
                .HasPrecision(8, 2);

            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.CORRENTE_ALTERNADA)
                .HasPrecision(8, 2);

            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.FATOR_POTENCIA)
                .HasPrecision(8, 2);

            modelBuilder.Entity<CIRCUITO>()
                .Property(e => e.CREATED_AT)
                .IsFixedLength();

            modelBuilder.Entity<PROJETO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<STATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.SENHA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIMENSAO_CABO>()
                .Property(e => e.DIAMENTRO_CABO)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DIMENSAO_CABO>()
                .Property(e => e.TIPO_INSTALACAO)
                .IsUnicode(false);
        }
    }
}
