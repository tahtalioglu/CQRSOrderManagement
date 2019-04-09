
using CQRSOrderManagementNew.Command;
using CQRSOrderManagementNew.Core;
using MassTransit;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CQRSOrderManagementNew.Consumer
{
    public class OrderConsumer : IConsumer<IOrderData>
    {
        IConnection _connection;
        IConfiguration _config;

        public OrderConsumer(IConnection connection, IConfiguration config)
        {
            _connection = connection;
            _config = config;

        }

        public async Task Consume(ConsumeContext<IOrderData> context)
        {
            var orderCommand = context.Message;
            var command = CommandFactory.GetCommand(orderCommand);

            command.ExecuteOrder(_connection);

        }
    }
}
