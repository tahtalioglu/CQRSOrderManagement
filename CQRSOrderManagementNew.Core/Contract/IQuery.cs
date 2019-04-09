using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public interface IQuery<out T>
    {
        T Execute(IConnection connection, object param = null);
    }
}