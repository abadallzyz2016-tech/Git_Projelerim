using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models
{
    internal class Member
    {
        public int  ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationsDate { get; set; }
        public List<Loan> loans { get; set; } = new List<Loan>();
    }
}
