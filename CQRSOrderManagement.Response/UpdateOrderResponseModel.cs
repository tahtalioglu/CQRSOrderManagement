using System;

namespace CQRSOrderManagement.Response
{
    public class UpdateOrderResponseModel
    {
       public bool isSuccess { get; set; }
    
        public int OrderId { get; set; }
    }
}
