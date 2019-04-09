using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public interface IOrderData
    {
        decimal Amount { get; set; }


        string OrderCode { get; set; }

        string Status { get; set; }

        int Id { get; set; }

        CommandType CommandType { get; set; }

    }
}
