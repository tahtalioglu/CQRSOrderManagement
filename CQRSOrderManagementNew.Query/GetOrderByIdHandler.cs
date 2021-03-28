using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSOrderManagementNew.Query
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderMain>
    {
        private readonly IConnection connection;

        public GetOrderByIdHandler(IConnection _connection)
        {
            connection = _connection;
        }

        public async Task<OrderMain> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await connection.QueryAsync<OrderMain>("SELECT * FROM [Order] with(nolock) Where Id = @Id", request._orderId);

            return result;
        }
    }
    
}
