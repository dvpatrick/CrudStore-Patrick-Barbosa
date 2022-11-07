namespace CrudStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CrudStore.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CrudStore.Models.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Produtos.AddOrUpdate(
                new Models.Produtos{ ProductName= "Prod1", Price = 10},
                new Models.Produtos{ ProductName= "Prod2", Price = 20},
                new Models.Produtos{ ProductName= "Prod3", Price = 30 }
                );
            context.SaveChanges();
        }
    }
}
