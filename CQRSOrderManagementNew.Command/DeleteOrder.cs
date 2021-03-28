using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Command
{
   public class DeleteOrder : IRequest<DeleteOrderResponseModel>
    {
        public int OrderId { get; set; }
         
    }
}
