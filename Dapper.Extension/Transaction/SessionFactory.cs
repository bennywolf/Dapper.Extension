﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    /// <summary>
    /// 会话工厂
    /// </summary>
    public static class SessionFactory
    {
        public static string ConnectionString { get; set; }

        public static string ProviderName { get; set; }

        private static DbProviderFactory ProviderFactory { get; set; }
        /// <summary>
        /// 初始化会话工厂
        /// </summary>
        static SessionFactory()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            var name = "strmysql";
            ProviderName = ConfigurationManager.ConnectionStrings[name].ProviderName;
            ConnectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            //ProviderFactory = DbProviderFactories.GetFactory(ProviderName);
        }
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <returns></returns>
        public static DbConnection GetConnection()
        {
            var connection =  new MySql.Data.MySqlClient.MySqlConnection();//ProviderFactory.CreateConnection();
            connection.ConnectionString = ConnectionString;
            return connection;
        }
        /// <summary>
        /// 获取会话
        /// </summary>
        /// <param name="proxy">是否使用会话代理</param>
        /// <returns></returns>
        public static ISession GetSession(bool proxy)
        {
            ISession session = null;
            if (proxy)
            {
                session = new SessionProxy(new DbSession(GetConnection()));
            }
            else
            {
                session = new DbSession(GetConnection());
            }
            return session;
        }
    }
}
