using Amigo_Chocolate.Dados.EntityFramework.Configurations;
using Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities;
using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Amigo_Chocolate.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        #region - Atributo e construtor

        private readonly DatabaseSettings _databaseSettings;

        public Contexto(DbContextOptions<Contexto> options, IOptions<DatabaseSettings> databaseSettings)
            : base(options)
        {
            _databaseSettings = databaseSettings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_databaseSettings.ConnectionString);
        }

        //public Contexto() : base()
        //{
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93,1434; 
        //                            Database = BD045304; 
        //                            User ID = RA045304; 
        //                            Password = 045304;
        //                            TrustServerCertificate=True");
        //}

        #endregion


        #region - Entities

        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<RecuperaSenha> RecuperaSenha { get; set; }
        public DbSet<Sorteio> Sorteio { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new RecuperaSenhaConfiguration());
            modelBuilder.ApplyConfiguration(new SorteioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
