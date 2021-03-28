using CQRSOrderManagementNew.Command;
using CQRSOrderManagementNew.Response;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using CQRSOrderManagementNew.Core;
using MassTransit;

namespace CQRSOrderManagementNew.Handler
{
    public class CreateOrderHandler : IRequestHandler<CreateOrder, CreateOrderResponseModel>
    {
        private readonly ISendEndpoint _sendEndpoint;

        public CreateOrderHandler(ISendEndpoint sendEndpoint)
        {
            _sendEndpoint = sendEndpoint;
        }
         
        public async Task<CreateOrderResponseModel> Handle(CreateOrder request, CancellationToken cancellationToken)
        {
           
            await _sendEndpoint.Send(request);

            var response = new CreateOrderResponseModel()
            {
                
                IsSuccess = true
            };
            return response;
        }
    }
}
