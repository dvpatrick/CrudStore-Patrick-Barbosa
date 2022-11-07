using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudStore.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Data Source=DVPATRICK;
            Initial Catalog=DbFromMigration;Integrated Security=True;
            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

        //public DataContext(): base(@"Data Source=(localdb)\MSSQLLocalDB;
        //    Initial Catalog=DbFromMigration;Integrated Security=True;
        //    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
        //    ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        { }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutosMap());
        }
    }
}

