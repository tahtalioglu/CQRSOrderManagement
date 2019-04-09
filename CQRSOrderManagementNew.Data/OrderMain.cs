using System;

namespace CQRSOrderManagementNew.Data
{
    public class OrderMain
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string OrderCode { get; set; }

        public OrderStatus Status { get; set; }
       
    }
}
