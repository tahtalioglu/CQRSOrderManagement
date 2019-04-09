using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRSOrderManagementNew.Query
{
    public class GetOrderById : IQuery<OrderMain>
    {
        public int _orderId { get; set; }
        public GetOrderById(int orderId)
        {
            _orderId = orderId;
        }
        public OrderMain Execute(IConnection connection, object param)
        {
          return connection.Query<OrderMain>("Select * from [Order] with(nolock) where Id=@Id", new {Id= _orderId });
        }
    }
}
