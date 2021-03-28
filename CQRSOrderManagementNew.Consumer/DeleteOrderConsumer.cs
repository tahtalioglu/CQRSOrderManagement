using CQRSOrderManagementNew.Command;
using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Response;
using MassTransit;
using System.Threading.Tasks;

namespace CQRSOrderManagementNew.Consumer
{
    public class DeleteOrderConsumer : IConsumer<DeleteOrder>
    {
        public readonly IConnection _connection;
        public DeleteOrderConsumer(IConnection connection)
        {
            _connection = connection;
        }

        public async Task Consume(ConsumeContext<DeleteOrder> context)
        {
            var result = _connection.Execute("Update [Order] Set IsActive=0 Where Id = @Id", new { Id = context.Message.OrderId});

            await context.RespondAsync<DeleteOrderResponseModel>(new
            {
                Value = $"Received: {result}"
            });
        }
    }
    
}
