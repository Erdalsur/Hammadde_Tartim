using Sanmark.Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IUserService
    {
        List<User> GetAll(Expression<Func<User, bool>> filter = null);
        User GetById(int id);
        void Add(User user);
        User UserCheck(string userName, string userPassword);
        bool PasswordChange(string userName, string userPassword, string newPassword);
    }
}
