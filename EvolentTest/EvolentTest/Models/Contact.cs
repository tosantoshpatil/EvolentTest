using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvolentTest.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}