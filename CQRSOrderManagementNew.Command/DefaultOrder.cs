using CQRSOrderManagementNew.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Command
{
    public class DefaultOrder : IOrderCommand
    {
        public void ExecuteOrder(IConnection connection)
        {
            Console.WriteLine("Komut Bulunamadı");
        }
    }
}
