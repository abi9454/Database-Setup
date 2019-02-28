using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
    public class Customer
    {
        [Key]

        public int CustomerId { get; set; }

        public User RelatedUsers{ get; set; }

        public string Address { get; set; }

        public virtual PaymentOption PaymentOptions { get; set; }
        
    }
}
