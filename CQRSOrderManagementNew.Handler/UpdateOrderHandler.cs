using CQRSOrderManagement.Response;
using CQRSOrderManagementNew.Command;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using CQRSOrderManagementNew.Data;
using CQRSOrderManagementNew.Core;
using MassTransit;

namespace CQRSOrderManagementNew.Handler
{
    public class UpdateOrderHandler : IRequestHandler<UpdateOrder, UpdateOrderResponseModel>
    {
        private readonly IConnection _connection;
        private readonly ISendEndpoint _sendEndpoint;

        public UpdateOrderHandler(IConnection connection, ISendEndpoint sendEndpoint)
        {
            _connection = connection;
            _sendEndpoint = sendEndpoint;
        }
        public async Task<UpdateOrderResponseModel> Handle(UpdateOrder request, CancellationToken cancellationToken)
        {

            await _sendEndpoint.Send(request);

            var result = new UpdateOrderResponseModel()
            {
                isSuccess = true,
                OrderId = 1
            };
            return result;
        }

 
    }
}
