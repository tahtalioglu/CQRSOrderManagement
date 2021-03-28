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
   public class DeleteOrderHandler : IRequestHandler<DeleteOrder, DeleteOrderResponseModel>
    {
        private readonly ISendEndpoint _sendEndpoint;

        public DeleteOrderHandler(ISendEndpoint sendEndpoint)
        {
            _sendEndpoint = sendEndpoint;
        }
  

        public async Task<DeleteOrderResponseModel> Handle(DeleteOrder request, CancellationToken cancellationToken)
        {
            await _sendEndpoint.Send(request);

            var result = new DeleteOrderResponseModel()
            {
                IsSuccess = true,
                Id = 1
            };
            return result;
        }
    }
     
}
