using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    /// <summary>
    /// 事物会话代理类
    /// </summary>
    public class SessionProxy : ISession
    {
        private ISession Target { get; set; }

        public List<DbCommand> Commands { get; set; }

        public SessionProxy(ISession target)
        {
            Target = target;
            Commands = new List<DbCommand>();
        }

        public int Execute(string sql, object param = null, CommandType text = CommandType.Text)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var row = Target.Execute(sql, param, text);
            watch.Stop();
            Commands.Add(new DbCommand()
            {
                Command = sql,
                CommandType = text,
                Method = "Execute",
                Param = param,
                Time = DateTime.Now,
                Text="执行数据库操纵命令",
                Watch = watch.ElapsedMilliseconds
            });
            return row;
        }

        public List<T> Query<T>(string sql, object param = null, CommandType text = CommandType.Text)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var list = Target.Query<T>(sql, param, text);
            watch.Stop();
            Commands.Add(new DbCommand()
            {
                Command = sql,
                CommandType = text,
                Method = "Query",
                Param = param,
                Time = DateTime.Now,
                Text="执行数据库查询命令",
                Watch = watch.ElapsedMilliseconds
            });
            return list;
        }

        public SqlFrom<T> From<T>() where T : class, new()
        {
            return new SqlFrom<T>(this);
        }

        public void Open(bool auto)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Target.Open(auto);
            watch.Stop();
            Commands.Add(new DbCommand()
            {
                Time = DateTime.Now,
                Watch = watch.ElapsedMilliseconds,
                Text = "开启连接,AutoCommit=" + auto
            });
        }

        public void Commit()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Target.Commit();
            watch.Stop();
            Commands.Add(new DbCommand()
            {
                Time = DateTime.Now,
                Watch = watch.ElapsedMilliseconds,
                Text = "提交事物"
            });
        }

        public void Rollback()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Target.Rollback();
            watch.Stop();
            Commands.Add(new DbCommand()
            {
                Time = DateTime.Now,
                Watch = watch.ElapsedMilliseconds,
                Text = "回滚事物"
            });
        }

        public void Close()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Target.Close();
            watch.Stop();
            Commands.Add(new DbCommand()
            {
                Time = DateTime.Now,
                Watch = watch.ElapsedMilliseconds,
                Text = "关闭回话"
            });
        }
    }
}
