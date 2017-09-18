
using System.IO;

using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using ProjetoModelo.Infra.Data.Extensions;
using ProjetoModelo.Infra.Data.EntityConfig;
using ProjetoModelo.Domain.Entities.Gestao;

namespace ProjetoModelo.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        public DbSet<TipoMaoObra> TiposMaoObra { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Commodity> Commodities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Remover pluralização no nome das tabelas
            //modelBuilder.RemovePluralizingTableNameConvention();


            modelBuilder.AddConfiguration(new TipoMaoObraMap());
            modelBuilder.AddConfiguration(new DisciplinaMap());
            modelBuilder.AddConfiguration(new CommodityMap());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }


        /// <summary>
        /// Verifica a entidade no momento da alteração para preencher a data de cadastro
        /// </summary>
        /// <returns>base.SaveChanges()</returns>
        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //
        //        if (entry.State == EntityState.Modified)
        //            entry.Property("DataCadastro").IsModified = false;
        //    }
        //
        //    return base.SaveChanges();
        //}
    }
}
