using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public interface IWriteStrategy
    {
        void Write(IOrderCommand command);
    }
}
