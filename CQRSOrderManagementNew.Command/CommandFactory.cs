using CQRSOrderManagementNew.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Command
{
   public class CommandFactory
    {
        public static IOrderCommand GetCommand(IOrderData data)
        {
            switch (data.CommandType)
            {
                case CommandType.Create:
                    CreateOrder createCommand = new CreateOrder(new OrderData
                    {
                        Amount = data.Amount,
                        OrderCode = data.OrderCode,
                        Status = data.Status
                    });
                    return createCommand;
                case CommandType.Update:
                    UpdateOrder updateCommand = new UpdateOrder(new OrderData
                    {
                        Amount = data.Amount,
                        Id = data.Id,
                        OrderCode = data.OrderCode,
                        Status = data.Status
                    });

                    return updateCommand; 
                case CommandType.Delete:
                    DeleteOrder deleteCommand = new DeleteOrder(data.Id);
                    return deleteCommand;
                case CommandType.Default:
                default:
                    return null;
            }
        }
    }
}
