using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudStore.Models
{
    public class ProdutosMap : EntityTypeConfiguration<Produtos>
    {
        public ProdutosMap()
            {
            ToTable("Produtos");
            HasKey(x => x.Id);
            Property(x => x.ProductName).IsRequired().HasColumnType
                ("varchar").HasMaxLength(70);
            Property(x => x.Price).IsRequired().HasColumnType
                ("int");
        }
    }
}