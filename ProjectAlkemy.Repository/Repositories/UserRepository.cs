using ProjectAlkemy.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlkemy.Repository.Repositories
{
    public class UserRepository
    {
        private readonly AlkemyContext _context;

        public UserRepository(AlkemyContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}
