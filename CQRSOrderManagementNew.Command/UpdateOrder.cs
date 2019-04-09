using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using System;

namespace CQRSOrderManagementNew.Command
{
    public class UpdateOrder : IOrderCommand
    {
        IOrderData _order;
        public UpdateOrder(IOrderData order)
        {
            _order = order;
        }
        public void ExecuteOrder(IConnection connection)
        {
            connection.Execute("Update [Order] set amount =@Amount, status=@Status where Id=@Id", new { Id = _order.Id, Amount= _order.Amount,Status = _order.Status });
        }
    }
}
