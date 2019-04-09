using CQRSOrderManagementNew.Data;
using System;
using System.Collections.Generic;

namespace CQRSOrderManagementNew.Core
{
    public interface IOrderReadManager
    {
        IList<OrderMain> GetOrders();
        OrderMain GetOrderById(int orderId);
    }
}