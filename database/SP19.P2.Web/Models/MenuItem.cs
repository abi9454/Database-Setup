using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public string picture { get; set; }
    }
}
