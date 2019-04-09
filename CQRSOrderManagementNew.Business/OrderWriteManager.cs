using CQRSOrderManagementNew.Command;
using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Business
{
    public class OrderWriteManager : IOrderWriteManager
    {
        IWriteStrategy _writeStrategy;
        public OrderWriteManager(IWriteStrategy writeStrategy)
        {
            _writeStrategy = writeStrategy;
        }
        public void DeleteOrder(int orderId)
        {
            IOrderCommand orderCommand = new DeleteOrder(orderId);

            _writeStrategy.Write(orderCommand);
        }

        public void InsertOrder(OrderMain order)
        {
            IOrderCommand orderCommand = new CreateOrder(new OrderData()
            {
                Amount = order.Amount,
                CommandType = CommandType.Create,
                OrderCode = order.OrderCode,
                Status = order.Status.GetDescription()
            }
                );

            _writeStrategy.Write(orderCommand);
        }

        public void UpdateOrder(OrderMain order)
        {
            IOrderCommand orderCommand = new UpdateOrder(new OrderData()
            {
                Id = order.Id,
                Amount = order.Amount,
                CommandType = CommandType.Create,
                OrderCode = order.OrderCode,
                Status = order.Status.GetDescription()
            });

            _writeStrategy.Write(orderCommand);

        }
    }
}
