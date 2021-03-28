using CQRSOrderManagement.Response;
using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using MediatR;
using System;

namespace CQRSOrderManagementNew.Command
{
    public class UpdateOrder : IRequest<UpdateOrderResponseModel>
    {
        public decimal Amount { get; set; }
        public string OrderCode { get; set; }
        public string Status { get; set; }

        public int Id { get; set; }
        
    }
}
