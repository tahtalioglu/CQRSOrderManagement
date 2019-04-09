using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CQRSOrderManagementNew.Data
{
    public enum OrderStatus
    {
        [Description("pending")]
        Pending,
        [Description("approved")]
        Approved,
        [Description("canceled")]
        Canceled,
    }
}
