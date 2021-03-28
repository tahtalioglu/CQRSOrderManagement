using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRSOrderManagementNew.Query
{
    public class GetAllOrdersQuery : MediatR.IRequest<List<OrderMain>>
    {


        public GetAllOrdersQuery()
        {
           
        }
 
    }
}
