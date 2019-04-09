

using CQRSOrderManagementNew.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public interface IContext
    {
        T Query<T>(IQuery<T> query);
        void Execute(IOrderCommand command);
    }
}
