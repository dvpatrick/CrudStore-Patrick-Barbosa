using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudStore.Models
{
    public class UsuariosMap : EntityTypeConfiguration<Usuarios>
    {
        public UsuariosMap()
        {
            ToTable("Usuarios");
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasColumnType
                ("varchar").HasMaxLength(70);
        }
    }
}