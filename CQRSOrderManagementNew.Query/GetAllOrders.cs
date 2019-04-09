using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRSOrderManagementNew.Query
{
    public class GetAllOrders : IQuery<IList<OrderMain>>
    {
        

        public IList<OrderMain> Execute(IConnection connection,object param =null)
        {
            return connection.QueryList<OrderMain>("SELECT * FROM [Order] with(nolock)",null).ToList();
        }

        
    }
}
