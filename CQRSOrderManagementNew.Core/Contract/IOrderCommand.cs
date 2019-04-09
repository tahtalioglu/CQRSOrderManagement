using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public interface IOrderCommand
    {
        void ExecuteOrder(IConnection connection);
    }
}