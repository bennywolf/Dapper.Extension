using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Dapper.Extension
{
    public class DbSession
    {
        #region Constructor
        public DbSession()
        {

        }
        public DbSession(DbConnection connection)
        {
            Connection = connection;
        }
        #endregion
        /// <summary>
        /// 数据库连接
        /// </summary>
        private DbConnection Connection { get; set; }
        /// <summary>
        /// 数据库事物
        /// </summary>
        private DbTransaction Transaction { get; set; }
        /// <summary>
        /// 会话状态
        /// </summary>
        public SessionState State = SessionState.Close;
        /// <summary>
        /// 会话SQL
        /// </summary>
        public List<DbCommand> Commands = new List<DbCommand>();
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
        /// 添加调试SQL
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="param">参数</param>
        /// <param name="text">命令类型</param>
        private void AddCommand(string sql, object param = null, CommandType text = CommandType.Text)
        {
            Commands.Add(new DbCommand()
            {
                Command = sql,
                CommandType = text,
                Params = param,
                Time = DateTime.Now
            });
        }
        /// <summary>
        /// 执行操作语句之前
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="param">参数</param>
        /// <param name="text">命令类型</param>
        private void Exceuting(string sql, object param = null, CommandType text = CommandType.Text)
        {
            AddCommand(sql, param, text);
        }
        /// <summary>
        /// 执行查询语句之前
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="param">参数</param>
        /// <param name="text">命令类型</param>
        private void Querying(string sql, object param = null, CommandType text = CommandType.Text)
        {
            AddCommand(sql, param, text);
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
            Exceuting(sql, param, text);
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
            Querying(sql, param, text);
            return Connection.Query<T>(sql, param, Transaction, false, Connection.ConnectionTimeout, text).ToList();
        }
        /// <summary>
        /// 开启会话
        /// </summary>
        /// <param name="auto">是否自动提交</param>
        public void Open(bool auto = true)
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

    }
    /// <summary>
    /// 会话状态
    /// </summary>
    public enum SessionState
    {
        /// <summary>
        /// 会话关闭
        /// </summary>
        Close = 0,
        /// <summary>
        /// 会话开启
        /// </summary>
        Open = 1,
        /// <summary>
        /// 会话关闭
        /// </summary>
        Commit = 2,
        /// <summary>
        /// 会话会滚
        /// </summary>
        Rollback = 3
    }
}
