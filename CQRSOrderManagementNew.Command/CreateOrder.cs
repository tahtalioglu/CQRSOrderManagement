using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using CQRSOrderManagementNew.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Command
{
    public class CreateOrder :IRequest<CreateOrderResponseModel>
    {
        public decimal Amount { get; set; }
        public string OrderCode { get; set; }
        public string Status { get; set; }

    }
}
