using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Dal.Concrete.EntityFramework.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
            this.context = context;
        }

        public User Login(User login)
        {
            var user = dbSet.Where(x => x.UserUsername == login.UserUsername && x.UserPassword == login.UserPassword).SingleOrDefault();

            return user;
        }

        public User Register(User register)
        {
            var userRegister = context.Add(register);
            context.SaveChanges();
            return userRegister.Entity;
        }
    }
}
