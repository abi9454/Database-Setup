using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }
        public LineItem LineItems { get; set; }
        public int TotalAmount { get; set; }
        public PaymentOption PaymentOption { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int PaymentReferenceNumber { get; set; }
        public int PaymentAuthNumber { get; set; }
    }
}
