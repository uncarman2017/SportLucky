using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedmapleSoft.FiveStarCoach.Domain.Utility
{
    /// <summary>
    /// MySQL数据库操作
    /// author:hhm
    /// date:2012-2-22
    /// </summary>
    public class MySqlDbHelper
    {
        #region 私有变量
        private const string defaultConfigKeyName = "FiveStarCoach";//连接字符串 默认Key
       
        private static MySqlDbHelper self = null;
        #endregion

       
        /// <summary>
        /// 默认构造函数(DbHelper)
        /// </summary>
        private MySqlDbHelper()
        {
           
        }

        public static MySqlDbHelper GetInstance()
        {
            if (self == null) self = new MySqlDbHelper();
            return self;
           
        }
       

        public int ExecuteNonQuery(string sql, params  MySqlParameter[] parameters)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings[defaultConfigKeyName].ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            foreach (MySqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            int res = 0;
            try
            {
                res = cmd.ExecuteNonQuery();
            }
            catch 
            {
                res = -1;
            }
            cmd.Dispose();
            conn.Close();
            return res;
        }

        public object ExecuteScalar(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings[defaultConfigKeyName].ConnectionString);
            
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            foreach (MySqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            object res = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();
            return res;
        }

        public DataTable ExecuteDataTable(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings[defaultConfigKeyName].ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            foreach (MySqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            DataSet dataset = new DataSet();//dataset放执行后的数据集合
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataset);
            cmd.Dispose();
            conn.Close();
            return dataset.Tables[0];
        }
    }
}
