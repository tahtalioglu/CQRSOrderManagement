using System.Collections.Generic;

namespace CQRSOrderManagementNew.Core
{
    public interface IConnection
    {
        IEnumerable<T> QueryList<T>(string query, object param);

        T Query<T>(string query, object param);
        void Execute(string query, object param);

    }
}