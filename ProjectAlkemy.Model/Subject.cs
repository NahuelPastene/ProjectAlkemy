using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlkemy.Model
{
    public class Subject : Entity
    {
        public string Name { get; set; }
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
        public int TeacherId { get; set; }
        public virtual User Teacher { get; set; }
        public int MaxStudents { get; set; }
    }
}
