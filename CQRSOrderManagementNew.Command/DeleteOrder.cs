using CQRSOrderManagementNew.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Command
{
   public class DeleteOrder :IOrderCommand
    {
        public int OrderId { get; set; }
        public DeleteOrder(int orderId)
        {
            OrderId = orderId;
        }
        public void ExecuteOrder(IConnection connection)
        {
            connection.Execute("Delete [Order] where Id=@Id", new { Id = OrderId});
        }
    }
}
