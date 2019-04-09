﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Data
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

        public int ProductId { get; set; }
    }
}
