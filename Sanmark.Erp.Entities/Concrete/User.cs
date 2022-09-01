using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete
{
    public class User : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
    }

    public class Role : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }
    }

    public class UserRole : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int RoleId { get; set; }
        public virtual int UserId { get; set; }
        public DateTime? KayitTarihi { get; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
