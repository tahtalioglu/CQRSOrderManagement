using CQRSOrderManagementNew.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public interface IOrderWriteManager
    {
        void UpdateOrder(OrderMain order);
        void InsertOrder(OrderMain order);
        void DeleteOrder(int orderId);
    }
}