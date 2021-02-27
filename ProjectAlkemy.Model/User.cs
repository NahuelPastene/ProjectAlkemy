using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAlkemy.Model
{
    public class User : Entity
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("DNI")]
        public int Dni { get; set; }
        [DisplayName("Active")]
        public bool Active { get; set; }
        [DisplayName("Is Teacher")]
        public bool IsTeacher { get; set; }
    }
}
