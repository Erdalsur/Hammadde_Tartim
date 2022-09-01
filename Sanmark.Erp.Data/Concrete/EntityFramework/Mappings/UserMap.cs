using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        /// <summary>
        /// Sirketler Tablosu Maping
        /// </summary>
        public UserMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.Email).HasColumnName("Email");
        }


    }
}
