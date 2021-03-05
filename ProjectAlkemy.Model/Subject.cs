using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjectAlkemy.Model
{
    public class Subject : Entity
    {
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("In")]
        public DateTime In { get; set; }
        [DisplayName("Out")]
        public DateTime Out { get; set; }
        [DisplayName("Teacher Id")]
        public int TeacherId { get; set; }
        [DisplayName("Teacher")]
        public virtual User Teacher { get; set; }
        [DisplayName("Max Student")]
        public int MaxStudents { get; set; }
    }
}
