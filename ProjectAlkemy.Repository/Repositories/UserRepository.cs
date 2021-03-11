using ProjectAlkemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Delete(User user)
        {
            user.Active = false;
            _context.Users.Update(user);
            _context.SaveChanges();
            return true;
        }

        public bool Edit(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return true;
        }

        public User GetById(int Id)
        {
            return _context.Users.Find(Id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.Where(x => x.Active);
        }

        public IEnumerable<User> GetTeachers()
        {
            return GetAll().Where(x => x.IsTeacher);
        }
        public IEnumerable<User> GetStudents()
        {
            return GetAll().Where(x => !x.IsTeacher);
        }
    }
}
