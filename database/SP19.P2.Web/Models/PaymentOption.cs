using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
    public class PaymentOption
    {
        public int PaymentOptionID { get; set; }
        public string Nickname { get; set; }
        public string TokenizedCardSystem { get; set; }
        public string BillingAddress { get; set; }
    }
}
