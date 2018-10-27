using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    #region 数据库表达式构建
    /// <summary>
    /// 数据库表达式构建
    /// </summary>
    public class ExpressionBuilder : ExpressionVisitor
    {
        #region Prop
        /// <summary>
        /// 表达式字符串
        /// </summary>
        public StringBuilder Expression = new StringBuilder();
        /// <summary>
        /// 表达式参数
        /// </summary>
        public Dictionary<string, object> Params = new Dictionary<string, object>();
        /// <summary>
        /// 类型
        /// </summary>
        private Type _type { get; set; }
        /// <summary>
        /// 字段栈
        /// </summary>
        private Stack<string> _columns = new Stack<string>();
        /// <summary>
        /// 运算符
        /// </summary>
        private string _operator;
        #endregion

        #region Method
        private void SetValue(object value)
        {
            var key = string.Format("@{0}_{1}", _columns.Pop(), Params.Count);
            if (_operator == "Like" || _operator == "NotLike")
            {
                value = "%" + value.ToString() + "%";
            }
            Expression.Append(key);
            Params.Add(key, value);
        }
        private void SetName(string name)
        {
            _columns.Push(name);
            Expression.Append(name);
        }
        #endregion
       
        #region Visiit
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {

            if (node.Arguments.Count == 2 && SqlOperator.Methods.Contains(node.Method.Name))
            {
                Expression.Append("(");
                Visit(node.Arguments[0]);
                _operator = SqlOperator.GetOperator(node.Method.Name);
                Expression.AppendFormat(" {0} ", _operator);
                Visit(node.Arguments[1]);
                Expression.Append(")");
            }
            else if (node.Arguments.Count == 1 && SqlOperator.Methods.Contains(node.Method.Name))
            {
                Expression.Append("(");
                Visit(node.Arguments[0]);
                _operator = SqlOperator.GetOperator(node.Method.Name);
                Expression.AppendFormat(" {0} ", _operator);
                Expression.Append(")");
            }
            else
            {
                var value = System.Linq.Expressions.Expression.Lambda(node).Compile().DynamicInvoke();
                SetValue(value);
            }
            return node;
        }
        protected override Expression VisitBinary(BinaryExpression node)
        {
            Expression.Append("(");
            Visit(node.Left);
            _operator = SqlOperator.GetOperator(node.NodeType);
            Expression.AppendFormat(" {0} ", _operator);
            Visit(node.Right);
            Expression.Append(")");
            return node;
        }
        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Expression != null && node.Expression.NodeType == ExpressionType.Parameter)
            {
                SetName(GetMemberName(_type, node));
            }
            else
            {
                var value = System.Linq.Expressions.Expression.Lambda(node).Compile().DynamicInvoke();
                SetValue(value);
            }

            return node;
        }
        protected override Expression VisitConstant(ConstantExpression node)
        {
            SetValue(node.Value);
            return node;
        }
        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            var value = System.Linq.Expressions.Expression.Lambda(node).Compile().DynamicInvoke();
            SetValue(value);
            return node;
        }
        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.NodeType == ExpressionType.Not)
            {
                Expression.Append(SqlOperator.GetOperator(node.NodeType));
                Visit(node.Operand);
            }
            else
            {
                Visit(node.Operand);
            }
            return node;
        }
        #endregion

        #region Utils
        /// <summary>
        /// 获取字段名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static string GetMemberName(Type type,Expression expression)
        {
            var name = string.Empty;
            if (expression is LambdaExpression)
            {
                expression = (expression as LambdaExpression).Body;
            }
            if (expression is MemberExpression)
            {
                name = (expression as MemberExpression).Member.Name;
            }
            else if (expression is UnaryExpression)
            {
                name = ((expression as UnaryExpression).Operand as MemberExpression).Member.Name;
            }
            else
            {
                throw new Exception("Not Cast MemberExpression");
            }
            return DbMap.GetColumnName(type,name);
        }
        /// <summary>
        /// 获取字段名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static string GetMemberName<T>(Expression expression)
        {
            return GetMemberName(typeof(T), expression);
        }
        /// <summary>
        /// 获取字段名列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="express"></param>
        /// <returns></returns>
        public static List<string> GetMemberNames<T>(Expression[] express)
        {
            var list = new List<string>();
            foreach (var item in express)
            {
                list.Add(GetMemberName<T>(item));
            }
            return list;
        }
        /// <summary>
        /// 构建表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expressionList"></param>
        /// <returns></returns>
        internal Builder Build<T>(List<SqlExpressionModel> expressionList)
        {
            _type = typeof(T);
            foreach (var item in expressionList)
            {
                if (!string.IsNullOrEmpty(item.Include))
                {
                    Expression.Append(item.Include);
                    continue;
                }
                if (!item.Equals(expressionList.FindAll(f=>string.IsNullOrEmpty(f.Include)).First()))
                {
                    Expression.AppendFormat(" {0} ",SqlOperator.GetOperator(item.ExpressType));
                }
                Visit(item.Express);
            }
            return new Builder()
            {
                Params = Params,
                Expression = Expression.ToString(),
            };
        }
        #endregion

        #region Class
        public class Builder
        {
            public string Expression { get; set; }
            public Dictionary<string,object> Params { get; set; }
        }
        #endregion
    }
    #endregion

    #region 数据库运算符
    /// <summary>
    /// 数据库运算符
    /// </summary>
    public static class SqlOperator
    {
        #region Cache
        public static List<string> Methods = new List<string>();
        static SqlOperator()
        {
            Methods = typeof(SqlOperator).GetMethods().Select(m => m.Name).ToList();
        }
        #endregion

        #region In
        public static bool In(this ValueType param, IEnumerable array)
        {
            return true;
        }
        public static bool NotIn(this ValueType param, IEnumerable array)
        {
            return true;
        }
        public static bool In(this string param, IEnumerable array)
        {
            return true;
        }
        public static bool NotIn(this string param, IEnumerable array)
        {
            return true;
        }
        #endregion

        #region Like
        public static bool Like(this string param1, string param2)
        {
            return true;
        }
        public static bool NotLike(this string param1, string param2)
        {
            return true;
        }
        #endregion

        #region <,>,<=,>=,<>,=
        public static bool Gt(this ValueType param1, ValueType param2)
        {
            return true;
        }
        public static bool Ge(this ValueType param1, ValueType param2)
        {
            return true;
        }
        public static bool Lt(this ValueType param1, ValueType param2)
        {
            return true;
        }
        public static bool Le(this ValueType param1, ValueType param2)
        {
            return true;
        }
        public static bool Ne(this ValueType param1, ValueType param2)
        {
            return true;
        }
        public static bool Eq(this ValueType param1, ValueType param2)
        {
            return true;
        }
        #endregion

        #region IsNull
        public static bool IsNull(this ValueType param)
        {
            return true;
        }
        public static bool IsNotNull(this ValueType param)
        {
            return true;
        }
        #endregion

        #region Merthod
        public static string GetOperator(string method)
        {
            var name = string.Empty;
            switch (method)
            {
                case "In":
                    name = "IN";
                    break;
                case "NotIn":
                    name = "NOT IN";
                    break;
                case "Like":
                    name = "Like";
                    break;
                case "NotLike":
                    name = "NOT LIKE";
                    break;
                case "Greater":
                    name = ">";
                    break;
                case "GreaterEqual":
                    name = ">=";
                    break;
                case "Less":
                    name = "<";
                    break;
                case "LessEqual":
                    name = "<=";
                    break;
                case "NotEqual":
                    name = "<>";
                    break;
                case "Equal":
                    name = "=";
                    break;
                case "IsNull":
                    name = "IS NULL";
                    break;
                case "IsNotNull":
                    name = "IS NOT NULL";
                    break;
                default: throw new Exception("Undefined Identifier Exception");
            }
            return name;
        }
        public static string GetOperator(ExpressionType node)
        {
            var name = string.Empty;
            switch (node)
            {
                case ExpressionType.AndAlso:
                    name = "AND";
                    break;
                case ExpressionType.Equal:
                    name = "=";
                    break;
                case ExpressionType.GreaterThan:
                    name = ">";
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    name = ">=";
                    break;
                case ExpressionType.LessThan:
                    name = "<";
                    break;
                case ExpressionType.LessThanOrEqual:
                    name = "<=";
                    break;
                case ExpressionType.Not:
                    name = "NOT";
                    break;
                case ExpressionType.NotEqual:
                    name = "<>";
                    break;
                case ExpressionType.OrElse:
                    name = "OR";
                    break;
                default:
                    break;
            }
            return name;
        }
        #endregion
    }
    #endregion

    #region 数据库表达式模型
    /// <summary>
    /// 数据库表达式模型
    /// </summary>
    public class SqlExpressionModel
    {
        public string Include { get; set; }
        public Expression Express { get; set; }
        public ExpressionType ExpressType { get; set; }
    }
    #endregion

    #region 数据库表达式
    /// <summary>
    /// 数据库表达式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SqlExpression<T> where T : class, new()
    {
        /// <summary>
        /// 表达式列表
        /// </summary>
        private List<SqlExpressionModel> Expressions = new List<SqlExpressionModel>();
        /// <summary>
        /// And运算
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlExpression<T> And(Expression<Func<T, bool>> expression)
        {
            Expressions.Add(new SqlExpressionModel()
            {
                ExpressType = ExpressionType.AndAlso,
                Express = expression,
            });
            return this;
        }
        /// <summary>
        /// Or运算
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlExpression<T> Or(Expression<Func<T, bool>> expression)
        {
            Expressions.Add(new SqlExpressionModel()
            {
                ExpressType = ExpressionType.OrElse,
                Express = expression,
            });
            return this;
        }
        /// <summary>
        /// 条件And运算
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlExpression<T> AndThen(bool condition, Expression<Func<T, bool>> expression)
        {
            if (condition)
            {
                Expressions.Add(new SqlExpressionModel()
                {
                    ExpressType = ExpressionType.AndAlso,
                    Express = expression,
                });
            }
            return this;
        }
        /// <summary>
        /// 条件Or运算
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public SqlExpression<T> OrThen(bool condition, Expression<Func<T, bool>> expression)
        {
            if (condition)
            {
                Expressions.Add(new SqlExpressionModel()
                {
                    ExpressType = ExpressionType.OrElse,
                    Express = expression,
                });
            }
            return this;
        }
        /// <summary>
        /// 左括号
        /// </summary>
        /// <returns></returns>
        public SqlExpression<T> Left()
        {
            Expressions.Add(new SqlExpressionModel()
            {
               Include="("

            });
            return this;
        }
        /// <summary>
        /// 右括号
        /// </summary>
        /// <returns></returns>
        public SqlExpression<T> Right()
        {
            Expressions.Add(new SqlExpressionModel()
            {
                Include = ")"

            });
            return this;
        }
        /// <summary>
        /// 构建表达式
        /// </summary>
        /// <returns></returns>
        public List<SqlExpressionModel> Build()
        {
            return Expressions;
        }

    }
    #endregion

    #region 数据库映射
    /// <summary>
    /// 数据库映射
    /// </summary>
    public static class DbMap
    {
        #region Cache

        /// <summary>
        /// 映射缓存
        /// </summary>
        static Dictionary<Type, DbTable> Tables = new Dictionary<Type, DbTable>();
        
        /// <summary>
        /// 缓存策略
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static DbTable Cache(Type type)
        {
            if (!Tables.ContainsKey(type))
            {
                var table = new DbTable();

                #region 如果存在类型注解则使用字段注解配置，否则使用属性名，并将第一个属性作为标识列
                var tableAttrs = type.GetCustomAttributes(typeof(TableAttribute), false);
                table.TableName = tableAttrs!=null&& tableAttrs.Length>0?(tableAttrs[0] as TableAttribute).Name:type.Name;
                #endregion

                #region 如果存在字段注解则使用字段注解配置，否则使用属性名，并将第一个属性作为标识列
                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    var propAttrs = prop.GetCustomAttributes(typeof(ColumnAttribute), false);
                    var name = propAttrs != null && propAttrs.Length > 0 ? (propAttrs[0] as ColumnAttribute).Name : prop.Name;
                    var isIdentity = propAttrs != null && propAttrs.Length > 0 ? (propAttrs[0] as ColumnAttribute).Identity : prop == props.First();
                    table.Columns.Add(new DbTable.DbColumn()
                    {
                        FieldName = prop.Name,
                        Identity = isIdentity,
                        ColumnName = name,
                    });
                }
                #endregion

                Tables.Add(type, table);

            }
            return Tables[type];
        }
       
        #endregion

        #region Methods

        /// <summary>
        /// 获取表名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetTableName<T>()
        {
            return Cache(typeof(T)).TableName;
        }
        /// <summary>
        /// 获取列名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetColumnName<T>(string fieldName)
        {
            return Cache(typeof(T)).Columns.Find(f => f.FieldName == fieldName).ColumnName;
        }
        /// <summary>
        /// 获取列名
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetColumnName(Type type,string fieldName)
        {
            return Cache(type).Columns.Find(f => f.FieldName == fieldName).ColumnName;
        }
        /// <summary>
        /// 获取所有列名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string[] GetColumnNames<T>()
        {
            return Cache(typeof(T)).Columns.Select(c => c.ColumnName).ToArray();
        }
        /// <summary>
        /// 获取所有字段名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string[] GetFieldNames<T>()
        {
            return Cache(typeof(T)).Columns.Select(c => c.FieldName).ToArray();
        }
        /// <summary>
        /// 是否为标识列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool IsIdentity<T>(string fieldName)
        {
            return Cache(typeof(T)).Columns.Find(f => f.FieldName == fieldName).Identity;
        }
        /// <summary>
        /// 获取标识列的列名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetIdentityFieldName<T>()
        {
            return Cache(typeof(T)).Columns.Find(f => f.Identity == true).FieldName;
        }
        #endregion

        #region Model
        public class DbTable
    {
        public string TableName { get; set; }

        public List<DbColumn> Columns = new List<DbColumn>();
        public class DbColumn
        {
            public string FieldName { get; set; }
            public string ColumnName { get; set; }
            public bool Identity { get; set; }
        }
    }
        #endregion
    }
    #endregion
}
