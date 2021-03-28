using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using Dapper;
 

namespace CQRSOrderManagementNew.Core
{
    public class DapperConnection : IConnection
    {
        private readonly IConfiguration _config;

        public DapperConnection(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }

        public virtual IEnumerable<T> QueryList<T>(string query, object param)
        {
            var result = Connection.Query<T>(query, param);
            return result;

        }

        public virtual T Query<T>(string query, object param)
        {
            var result = Connection.QueryFirst<T>(query, param);
            return result;
        }


        public int Execute(string sql, object param)
        {
            return Connection.Execute(sql, param);
        }

        public async Task<IEnumerable<T>> QueryListAsync<T>(string sql, object param)
        {
            return await Connection.QueryAsync<T>(sql, param);
        }

        public async Task<T> QueryAsync<T>(string query, object param)
        {
            return await Connection.QueryFirstAsync<T>(query, param);
        }
    }
}





















