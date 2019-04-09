using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }
    }
}
