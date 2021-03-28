using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Response
{
    public class DeleteOrderResponseModel
    {
        public int Id { get; set; }
        public bool IsSuccess { get; set; }
    }
}
