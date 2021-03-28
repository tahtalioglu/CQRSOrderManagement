using CQRSOrderManagementNew.Command;
using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Response;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRSOrderManagementNew.Consumer
{
    public class CreateOrderConsumer :IConsumer<CreateOrder>
    {
        public readonly IConnection _connection;
        public CreateOrderConsumer(IConnection connection)
        {
            _connection = connection;
        }

        public async Task Consume(ConsumeContext<CreateOrder> context)
        {
            var result = _connection.Execute("Insert Into [Order] Values(@Amount,Status", new { Amount = context.Message.Amount, Status = context.Message.Status });

            await context.RespondAsync<CreateOrderResponseModel>(new
            {
                Value = $"Received: {result}"
            });
        }
    }
}
