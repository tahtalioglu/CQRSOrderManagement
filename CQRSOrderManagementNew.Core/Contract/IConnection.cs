using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSOrderManagementNew.Core
{
    public interface IConnection
    {
        IEnumerable<T> QueryList<T>(string query, object param);

        T Query<T>(string query, object param);
        int Execute(string query, object param);
        Task<IEnumerable<T>> QueryListAsync<T>(string v, object p);

        Task<T> QueryAsync<T>(string query, object param);
    }
}