using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
   
        public class LineItem
        {
            [Key]
            public int LineId { get; set; }
            public string Description { get; set; }
            public int Amount { get; set; }
            public string PerItemCost { get; set; }
        }
    }

