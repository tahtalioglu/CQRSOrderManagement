using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSOrderManagementNew.Model
{
    public class OrderModel
    {
        public string OrderCode { get; set; }

        public string Status { get; set; }

        public decimal Amount { get; set; }
        public int OrderId { get; set; }
    }
}
