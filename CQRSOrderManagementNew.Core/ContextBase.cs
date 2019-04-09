using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public class ContextBase : IContext
    {
        public void Execute(IOrderCommand command)
        {
            throw new NotImplementedException();
        }

        public T Query<T>(IQuery<T> query)
        {
            throw new NotImplementedException();
        }
    }
}
