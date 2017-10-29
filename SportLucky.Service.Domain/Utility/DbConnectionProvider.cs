using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace SportLucky.Service.Domain.Utility
{
    public class DbConnectionProvider :IDisposable
    {
        protected IDbConnection _connection;
        protected string _connectionName;

        public string ConnectionName {
            get
            {
                return this._connectionName;
            }
        }

        public DbConnectionProvider(string connectionName)
        {
            this._connectionName = connectionName;
        }

        public IDbConnection GetOpenConnection()
        {
            if (this._connection != null && this._connection.State!= ConnectionState.Closed)
            {
                return this._connection;
            }
            else
            {
                ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings[this._connectionName];
                if (cs == null)
                    throw new Exception(String.Format("链接字符串 '{0}' 未找到。", this._connectionName));


                this._connection = DbProviderFactories.GetFactory(cs.ProviderName).CreateConnection();
                this._connection.ConnectionString = cs.ConnectionString;
                this._connection.Open();
                return this._connection;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_connection != null)
            {
                if (this._connection.State != ConnectionState.Closed)
                    this._connection.Close();
                this._connection.Dispose();
            }
        }

        #endregion
    }
}
