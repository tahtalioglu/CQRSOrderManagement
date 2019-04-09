

namespace CQRSOrderManagementNew.Core
{
    public class OrderData : IOrderData
    {

        public decimal Amount { get; set; }
        public string OrderCode { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public CommandType CommandType { get; set; }
    }
}
