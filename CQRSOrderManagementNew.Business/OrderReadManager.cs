using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using CQRSOrderManagementNew.Query;
using System;
using System.Collections.Generic;

namespace CQRSOrderManagementNew.Business
{
    public class OrderReadManager : IOrderReadManager
    {
        private IConnection _connection { get; set; }
        public OrderReadManager(IConnection connection)
        {
            _connection = connection;
        }
        //getler için ayrı bir class
        //setler için ayrı bir class
        public IList<OrderMain> GetOrders()
        {
            var orders = new GetAllOrders();
            return orders.Execute(_connection, null);

        }

        public OrderMain GetOrderById(int orderId)
        {
            var orders = new GetOrderById(orderId);
            return orders.Execute(_connection,null);
        }
    }
}
