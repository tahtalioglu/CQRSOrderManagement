using CQRSOrderManagementNew.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Business.Strategy
{
    public class DatabaseStrategy : IWriteStrategy
    {
        IConnection _connection;
        public DatabaseStrategy(IConnection connection)
        {
            _connection = connection;
        }
        public void Write(IOrderCommand command)
        {
            command.ExecuteOrder(_connection);

        }
    }
}
