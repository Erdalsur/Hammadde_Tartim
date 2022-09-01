using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            user.KayitTarihi = DateTime.Now;
            user.KayitUserId = UserSession.CurrentUser.Id;
            _userDal.Add(user);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetList(filter);
        }

        public User GetById(int id)
        {
            return _userDal.Get(f => f.Id == id);
        }

        public bool PasswordChange(string userName, string userPassword, string newPassword)
        {
            bool durum = false;
            var user = UserCheck(userName, userPassword);
            if (user != null)
            {
                durum = true;
                user.Password = newPassword;
                user.DegistirmeTarihi = DateTime.Now;
                user.DegistirmeUserId = user.Id;
                _userDal.Update(user);
            }
            return durum;
        }

        public User UserCheck(string userName, string userPassword)
        {
            User _user = GetAll(f => f.UserName == userName && f.Password == userPassword).FirstOrDefault();
            return _user;
        }
    }
}
