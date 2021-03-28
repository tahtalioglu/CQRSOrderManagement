using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRSOrderManagementNew.Query
{
    public class GetOrderByIdQuery : IRequest<OrderMain>
    {
        public int _orderId { get; set; }
        public GetOrderByIdQuery(int orderId)
        {
            _orderId = orderId;
        }
        
    }
}
