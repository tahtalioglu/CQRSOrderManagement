using CQRSOrderManagementNew.Core;
using MassTransit;
using CQRSOrderManagementNew.Command;
using System.Threading.Tasks;
using CQRSOrderManagement.Response;

namespace CQRSOrderManagementNew.Consumer
{
    public class UpdateOrderConsumer : IConsumer<UpdateOrder>
    {
        public readonly IConnection _connection;
        public UpdateOrderConsumer(IConnection connection)
        {
            _connection = connection;
        }

        public async Task Consume(ConsumeContext<UpdateOrder> context)
        {

            var result =_connection.Execute("Update [Order] set amount =@Amount, status=@Status where Id=@Id", new { Id = context.Message.Id, Amount = context.Message.Amount, Status = context.Message.Status });


            await context.RespondAsync<UpdateOrderResponseModel>(new
            {
                Value = $"Received: {result}"
            });
        }
    }
}
