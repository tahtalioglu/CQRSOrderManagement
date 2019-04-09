using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
   public enum CommandType
    {
        Create=1,
        Update=2,
        Delete=3,
        Default=0
    }
}
