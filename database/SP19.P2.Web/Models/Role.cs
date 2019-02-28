﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        public string Name{ get; set; }


        public ICollection<User> Users { get; set; }




        
    }
}
