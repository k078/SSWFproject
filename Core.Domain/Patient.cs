using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{ public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {get{ return this.FirstName + " " + this.LastName; } }
        public string Email { get; set; } //Email moet uniek zijn, PK
        public int Telephone { get; set; }
        public Role Role { get; set; }
        public int RoleNumber { get; set; }
        public DateOnly BirthDate { get; set; } //Moet minimaal 16 jaar oud en niet in de toekomst
        public Gender Gender { get; set; }
    }
}
