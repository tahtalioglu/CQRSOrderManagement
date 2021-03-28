using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSOrderManagementNew.Query
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<OrderMain>>
    {
        private readonly IConnection connection;

        public GetAllOrdersHandler(IConnection _connection)
        {
            connection = _connection;
        }

        public async Task<List<OrderMain>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {

            var result = await connection.QueryListAsync<OrderMain>("SELECT * FROM [Order] with(nolock)", null);

            return result.ToList();

        }
    }
}
