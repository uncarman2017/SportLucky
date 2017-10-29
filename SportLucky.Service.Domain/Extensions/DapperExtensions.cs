using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SportLucky.Service.Domain
{
    public static class DapperExtensions
    {
        public static IEnumerable<T> Query<T>(this IDbConnection cnn, string sql, object param = null, System.Data.CommandType cmdType = CommandType.Text)
        {
            return cnn.Query<T>(sql, param, null, true, null, cmdType).ToList();
        }

        public static int ExecuteNoneQuery(this IDbConnection cnn, string sql, object param = null, System.Data.CommandType cmdType = CommandType.Text)
        {
            return cnn.Execute(sql,param,null,null,cmdType);
        }

        public static T ExecuteScalar<T>(this IDbConnection cnn, string sql, object param = null, System.Data.CommandType cmdType = CommandType.Text)
        {
            return cnn.ExecuteScalar<T>(sql, param, null, null, cmdType);
        }
    }
}
