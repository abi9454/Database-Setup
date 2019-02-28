using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
    public class TableBill
    {
        [Key]
        public int TableBillId { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Table Table { get; set; }
        public TableFoodItem TableFoodItem { get; set; }
        
    }
}
