using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Command
{
    public class CreateOrder : IOrderCommand
    {
        private readonly IOrderData _order;

        public CreateOrder(IOrderData order)
        {
            _order = order;
        }
        public void ExecuteOrder(IConnection connection)
        {
            connection.Execute("Insert Into [Order] Values(@Amount,getdate(),@OrderCode,@Status)", new { Amount = _order.Amount, OrderCode = _order.OrderCode, _order.Status });
        }


    }
}
