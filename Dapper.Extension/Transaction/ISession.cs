using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    /// <summary>
    /// 会话接口
    /// </summary>
    public interface ISession
    {

        /// <summary>
        /// 数据库操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        SqlFrom<T> From<T>() where T : class, new();
        /// <summary>
        /// 执行SQL语句并返会影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        int Execute(string sql, object param = null, CommandType text = CommandType.Text);

        /// <summary>
        /// 执行SQL语句并返会查询结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        List<T> Query<T>(string sql, object param = null, CommandType text = CommandType.Text);

        /// <summary>
        /// 开启会话
        /// </summary>
        /// <param name="auto">是否自动提交</param>
        void Open(bool auto);

        /// <summary>
        /// 提交事务
        /// </summary>
        void Commit();

        /// <summary>
        /// 会滚事物
        /// </summary>
        void Rollback();

        /// <summary>
        /// 关闭事物
        /// </summary>
        void Close();

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
