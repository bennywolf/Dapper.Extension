using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Extension;

namespace Dapper.Extension
{
    public class DbSession : ISession
    {
        #region Constructor
        public DbSession() : this(null)
        {

        }
        public DbSession(DbConnection connection)
        {
            Connection = connection;
            State = SessionState.Close;
        }
        #endregion

        #region Propertiy
        /// <summary>
        /// 数据库连接
        /// </summary>
        public DbConnection Connection { get; set; }
        /// <summary>
        /// 数据库事物
        /// </summary>
        public DbTransaction Transaction { get; set; }
        /// <summary>
        /// 会话状态
        /// </summary>
        public SessionState State { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// 数据库操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public SqlFrom<T> From<T>() where T : class, new()
        {
            var from = new SqlFrom<T>(this);
            return from;
        }
        /// <summary>
        /// 执行SQL语句并返会影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public int Execute(string sql, object param = null, CommandType text = CommandType.Text)
        {
            return Connection.Execute(sql, param, Transaction, Connection.ConnectionTimeout, text);
        }
        /// <summary>
        /// 执行SQL语句并返会查询结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public List<T> Query<T>(string sql, object param = null, CommandType text = CommandType.Text)
        {
            return Connection.Query<T>(sql, param, Transaction, false, Connection.ConnectionTimeout, text).ToList();
        }
        /// <summary>
        /// 开启会话
        /// </summary>
        /// <param name="auto">是否自动提交</param>
        public void Open(bool auto)
        {
            if (Connection != null && State == SessionState.Close)
            {
                Connection.Open();
                Transaction = auto ? null : Connection.BeginTransaction();
                State = SessionState.Open;
            }
        }
        /// <summary>
        /// 提交事务
        /// </summary>
        public void Commit()
        {
            if (Transaction != null && State == SessionState.Open)
            {
                Transaction.Commit();
                State = SessionState.Commit;
            }
        }
        /// <summary>
        /// 会滚事物
        /// </summary>
        public void Rollback()
        {
            if (Transaction != null && State == SessionState.Open)
            {
                Transaction.Rollback();
                State = SessionState.Rollback;
            }
        }
        /// <summary>
        /// 关闭事物
        /// </summary>
        public void Close()
        {
            if (Transaction != null)
            {
                Transaction.Dispose();
            }
            if (Connection != null && State != SessionState.Close)
            {
                Connection.Close();
                Connection.Dispose();
            }
            State = SessionState.Close;
        }
        #endregion

    }

}
