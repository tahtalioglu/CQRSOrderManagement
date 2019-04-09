using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

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


        public void Execute(string sql, object param)
        {

            Connection.Execute(sql, param);
        }


    }
}





















