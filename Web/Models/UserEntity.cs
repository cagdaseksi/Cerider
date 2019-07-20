using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class UserEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BirthDate { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Adress { get; set; }
    }
}