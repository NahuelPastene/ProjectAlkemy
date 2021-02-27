using ProjectAlkemy.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlkemy.Repository.Repositories
{
    public class SubjectRepository
    {
        private readonly AlkemyContext _context;
        public SubjectRepository(AlkemyContext context)
        {
            _context = context;
        }
        public Subject Create(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
            return subject;
        }
        public IEnumerable<Subject> GetAll()
        {
            return _context.Subjects;
        }
    }
}
