using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAlkemy.Model
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Dni { get; set; }
        public bool Active { get; set; }
        public bool IsTeacher { get; set; }
    }
}
