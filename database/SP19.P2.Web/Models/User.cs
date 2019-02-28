using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
  
        public class User
        {
            [Key]
            public String Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int RoleId { get; set; }
            public Role Role { get; set; }
            

    }
}

    