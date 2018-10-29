﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dapper.Extension
{
    public class SqlFrom<T> where T : class, new()
    {
        #region prop
        private ISession Session { get; set; }
        public SqlFrom(ISession session)
        {
            Session = session;
        }
        #endregion

        #region DAO
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="columns">字段列表</param>
        /// <returns></returns>
        public List<T> Select(string columns = "*")
        {
            #region 构建QuerySql
            QuerySql.AppendFormat("SELECT {0} FROM {1}", columns, DbMap.GetTableName<T>());
            if (_where != null)
            {
                QuerySql.AppendFormat(" WHERE {0}", _where);
            }
            if (_groupBy != null)
            {
                QuerySql.AppendFormat(" GROUP BY {0}", _groupBy);
            }
            if (_having != null)
            {
                QuerySql.AppendFormat(" HAVING {0}", _having);
            }
            if (_orderBy != null)
            {
                QuerySql.AppendFormat(" ORDER BY {0}", _orderBy);
            }
            if (_top != null)
            {
                QuerySql.AppendFormat(" {0}", _top);

            }
            #endregion

            #region 执行Dapper查询
            var data = Session.Query<T>(QuerySql.ToString(), Params, CommandType.Text).ToList();
            #endregion

            return data;
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="express">字段列表</param>
        /// <returns></returns>
        public List<T> Select(params Expression<Func<T, object>>[] express)
        {
            #region 构建字段列表
            var columns = string.Join(",", ExpressionBuilder.GetColumnNames<T>(express));
            #endregion

            #region 执行Dapper查询
            var data = Select(columns);
            #endregion

            return data;
        }
        /// <summary>
        /// 将字段进行映射
        /// </summary>
        /// <param name="express"></param>
        /// <returns></returns>
        public List<T> AsSelect(params Expression<Func<T, object>>[] express)
        {
            #region 构建字段列表
            var list = ExpressionBuilder.GetColumnNames<T>(express);

            var columns = string.Join(",", ExpressionBuilder.GetColumnAsFields<T>(express));
            #endregion

            #region 执行Dapper查询
            var data = Select(columns);
            #endregion

            return data;
        }
        public List<T> SkipPage(int index, int size, out int total)
        {
            total = Count();
            Top(((total + size) / size) * (index - 1), size);
            var data = Select();
            return data;
        }
        /// <summary>
        /// 查询单个数据
        /// </summary>
        /// <param name="columns">字段列表</param>
        /// <returns></returns>
        public T Single(string columns = "*")
        {
            #region 构建QuerySql
            Top(0, 1);
            #endregion

            #region 执行Dapper查询
            var data = Select(columns).SingleOrDefault();
            #endregion

            return data;
        }
        /// <summary>
        /// 查询单个数据
        /// </summary>
        /// <param name="express">字段列表</param>
        /// <returns></returns>
        public T Single(params Expression<Func<T, object>>[] express)
        {

            #region 构建字段列表
            var columns = string.Join(",", ExpressionBuilder.GetColumnNames<T>(express));
            #endregion

            #region 执行Dapper查询
            var data = Single(columns);
            #endregion

            return data;
        }
        /// <summary>
        /// 判断指定条件的数据格个数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            #region 构建QuerySql
            TopSql.AppendFormat("SELECT COUNT(*) FROM {0}", DbMap.GetTableName<T>());
            if (_where != null)
            {
                TopSql.AppendFormat(" WHERE {0}", _where);
            }
            if (_top != null)
            {
                TopSql.AppendFormat(" {0}", _top);
            }
            #endregion

            #region 执行Dapper查询
            var count = Session.Query<int>(TopSql.ToString(), Params, CommandType.Text).SingleOrDefault();
            #endregion

            return count;
        }
        /// <summary>
        /// 判断指定条件的数据是否存在
        /// </summary>
        /// <returns></returns>
        public bool Exists()
        {

            #region 执行Dapper查询
            var count = Count();
            #endregion

            return count > 0 ? true : false;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Insert(T entity)
        {
            #region 如果对象为null，则不做更新
            if (entity == null)
            {
                return 0;
            }
            #endregion

            #region 构建InsertSql
            var colums = DbMap.GetColumnNames<T>();
            var fields = DbMap.GetFieldNames<T>();
            InsertSql.AppendFormat("INSERT INTO {0} ({1}) VALUES ({2})", DbMap.GetTableName<T>(), string.Join(",", colums), string.Join(",", fields.Select(c => c = '@' + c).ToArray()));
            #endregion

            #region 执行Dapper
            var row = Session.Execute(InsertSql.ToString(), entity, CommandType.Text);
            #endregion

            return row;
        }
        public int Insert(IEnumerable<T> entitys)
        {
            #region 如果对象为null，则不做更新
            if (entitys == null || entitys.Count() == 0)
            {
                return 0;
            }
            #endregion

            #region 构建InsertSql
            var colums = DbMap.GetColumnNames<T>();
            var fields = DbMap.GetFieldNames<T>();
            InsertSql.AppendFormat("INSERT INTO {0} ({1}) VALUES ({2})", DbMap.GetTableName<T>(), string.Join(",", colums), string.Join(",", fields.Select(c => c = '@' + c).ToArray()));
            #endregion

            #region 执行Dapper
            var row = Session.Execute(InsertSql.ToString(), entitys, CommandType.Text);
            #endregion

            return row;
        }
        /// <summary>
        /// SET执行更新
        /// </summary>
        /// <returns></returns>
        public int Update()
        {
            #region 构建UpdateSql
            UpdateSql.AppendFormat("UPDATE {0}", DbMap.GetTableName<T>());
            UpdateSql.AppendFormat(" SET {0}", _set);
            if (_where != null)
            {
                UpdateSql.AppendFormat(" WHERE {0}", _where);
            }
            #endregion

            #region 执行Dapper
            var row = Session.Execute(UpdateSql.ToString(), Params, CommandType.Text);
            #endregion

            return row;
        }
        /// <summary>
        /// 更新指定实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(T entity)
        {
            #region 如果对象为null，则不做更新
            if (entity == null)
            {
                return 0;
            }
            #endregion

            #region 构建UpdateSql
            var colums = DbMap.GetColumnNames<T>();
            var fields = DbMap.GetFieldNames<T>();
            UpdateSql.AppendFormat("UPDATE {0} SET {1}", DbMap.GetTableName<T>(), string.Join(",", fields.Select(s => s + "=@" + s)));
            UpdateSql.AppendFormat(" WHERE {0}=@{0}", DbMap.GetIdentityFieldName<T>());
            #endregion

            #region 执行Dapper
            var row = Session.Execute(UpdateSql.ToString(), entity, CommandType.Text);
            #endregion

            return row;
        }
        /// <summary>
        /// 批量更新实体
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        public int Update(IEnumerable<T> entitys)
        {
            #region 如果对象为null，则不做更新
            if (entitys == null || entitys.Count() == 0)
            {
                return 0;
            }
            #endregion

            #region 构建UpdateSql
            var colums = DbMap.GetColumnNames<T>();
            var fields = DbMap.GetFieldNames<T>();
            UpdateSql.AppendFormat("UPDATE {0} SET {1}", DbMap.GetTableName<T>(), string.Join(",", fields.Select(s => s + "=@" + s)));
            UpdateSql.AppendFormat(" WHERE {0}=@{0}", DbMap.GetIdentityFieldName<T>());
            #endregion

            #region 执行Dapper
            var row = Session.Execute(UpdateSql.ToString(), entitys, CommandType.Text);
            #endregion

            return row;
        }
        /// <summary>
        /// 删除指定条件的数据
        /// </summary>
        /// <returns></returns>
        public int Delete()
        {
            #region 构建DeleteSql
            DeleteSql.AppendFormat("DELETE FROM {0}", DbMap.GetTableName<T>());
            if (_where != null)
            {
                DeleteSql.AppendFormat(" WHERE {0}", _where);
            }
            #endregion

            #region 执行Dapper
            var row = Session.Execute(DeleteSql.ToString(), Params, CommandType.Text);
            #endregion

            return row;
        }
        /// <summary>
        /// 更据对象标识删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(T entity)
        {
            #region 如果对象为null，则不做更新
            if (entity == null)
            {
                return 0;
            }
            #endregion

            #region 构建DeleteSql
            DeleteSql.AppendFormat("DELETE FROM {0}", DbMap.GetTableName<T>());
            DeleteSql.AppendFormat(" WHERE {0}=@{0}", DbMap.GetIdentityFieldName<T>());
            #endregion

            #region 执行Dapper
            var row = Session.Execute(DeleteSql.ToString(), entity, CommandType.Text);
            #endregion

            return row;
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        public int Delete(IEnumerable<T> entitys)
        {
            #region 如果对象为null，则不做更新
            if (entitys == null || entitys.Count() == 0)
            {
                return 0;
            }
            #endregion

            #region 构建DeleteSql
            DeleteSql.AppendFormat("DELETE FROM {0}", DbMap.GetTableName<T>());
            DeleteSql.AppendFormat(" WHERE {0}=@{0}", DbMap.GetIdentityFieldName<T>());
            #endregion

            #region 执行Dapper
            var row = Session.Execute(DeleteSql.ToString(), entitys, CommandType.Text);
            #endregion

            return row;
        }
        #endregion

        #region SQL
        /// <summary>
        /// 查询参数
        /// </summary>
        public Dictionary<string, object> Params = new Dictionary<string, object>();
        /// <summary>
        /// 查询SQL
        /// </summary>
        private StringBuilder QuerySql = new StringBuilder();
        /// <summary>
        /// 插入SQL
        /// </summary>
        public StringBuilder InsertSql = new StringBuilder();
        /// <summary>
        /// 删除SQL
        /// </summary>
        public StringBuilder DeleteSql = new StringBuilder();
        /// <summary>
        /// 更新SQL
        /// </summary>
        public StringBuilder UpdateSql = new StringBuilder();
        /// <summary>
        /// 分页SQL
        /// </summary>
        public StringBuilder TopSql = new StringBuilder();
        #endregion

        #region Where
        private StringBuilder _where { get; set; }
        /// <summary>
        /// 条件过滤
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlFrom<T> Where(SqlExpression<T> expression)
        {
            var build = new ExpressionBuilder().Build<T>(Params,expression.Build());
            _where = new StringBuilder(build.Expression);
            return this;
        }
        /// <summary>
        /// 条件过滤
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlFrom<T> Where(Expression<Func<T, bool>> expression)
        {
            var query = new SqlExpression<T>();
            query.And(expression);
            Where(query);
            return this;
        }
        #endregion

        #region Update
        private StringBuilder _set = new StringBuilder();
        /// <summary>
        /// 更新指定字段
        /// </summary>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public SqlFrom<T> Set(string column, object value)
        {
            var key = "@" + column;
            _set.AppendFormat("{0}=@{0}", column);
            Params.Add(key, value);
            return this;
        }
        /// <summary>
        /// 更新指定字段
        /// </summary>
        /// <param name="express"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public SqlFrom<T> Set(Expression<Func<T, object>> express, object value)
        {
            Set(ExpressionBuilder.GetColumnName<T>(express.Body), value);
            return this;
        }
        #endregion

        #region Group By
        private StringBuilder _groupBy = null;
        public SqlFrom<T> GroupBy(params Expression<Func<T, object>>[] express)
        {
            if (_groupBy == null)
            {
                _groupBy = new StringBuilder();
            }
            var columns = string.Join(",", ExpressionBuilder.GetColumnNames<T>(express));
            _groupBy.AppendFormat(" {0}", string.Join(",", columns));
            return this;
        }
        private StringBuilder _having { get; set; }
        /// <summary>
        /// 分组筛选
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlFrom<T> Having(SqlExpression<T> expression)
        {
            var build = new ExpressionBuilder().Build<T>(Params,expression.Build());
            _having = new StringBuilder(build.Expression);
            return this;
        }
        /// <summary>
        /// 分组筛选
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlFrom<T> Having(Expression<Func<T, bool>> expression)
        {
            var query = new SqlExpression<T>();
            query.And(expression);
            Having(query);
            return this;
        }
        #endregion        

        #region OrderBy
        private StringBuilder _orderBy { get; set; }
        /// <summary>
        /// 倒叙
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public SqlFrom<T> Desc(Expression<Func<T, object>> orderBy)
        {
            var name = ExpressionBuilder.GetColumnName<T>(orderBy.Body);
            OrderBy(string.Format("{0} DESC", name));
            return this;
        }
        /// <summary>
        /// 升序
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public SqlFrom<T> Asc(Expression<Func<T, object>> orderBy)
        {
            var name = ExpressionBuilder.GetColumnName<T>(orderBy.Body);
            OrderBy(string.Format("{0} ASC", name));
            return this;
        }
        /// <summary>
        /// 自定义
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public SqlFrom<T> OrderBy(string orderBy)
        {
            if (_orderBy == null)
            {
                _orderBy = new StringBuilder();
                _orderBy.Append(orderBy);
            }
            _orderBy.AppendFormat(",{0}", orderBy);
            return this;
        }
        #endregion

        #region Top
        private string _top { get; set; }
        /// <summary>
        /// Limit查询
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public SqlFrom<T> Top(int index, int size)
        {
            _top = string.Format("LIMIT {0},{1}", index, size);
            return this;
        }
        public SqlFrom<T> Top(int size)
        {
            Top(0, size);
            return this;
        }
        #endregion
    }

}
