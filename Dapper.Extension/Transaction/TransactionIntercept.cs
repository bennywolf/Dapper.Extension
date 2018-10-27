using Castle.DynamicProxy;
using Dapper.Extension;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Dapper.Extension
{
    public class TransactionIntercept : IInterceptor
    {
        /// <summary>
        /// 事物拦截器
        /// 事务传播行为：如果ISevice的实现类中的Session未初始化则将其初始化
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {
            DbSession session = null;
            try
            {
                var target = invocation.InvocationTarget;
                //如果目标对象实现了ISession接口则注入事物，自动提交回滚
                if (target is ISevice)
                {
                    var dao = target as ISevice;
                    //事务传播行为，如果同一个Service则使用同一个事物
                    session = dao.Session == null ? SessionFactory.GetSession(false) : null;
                    //注入事务
                    dao.Session = session;
                }
                invocation.Proceed();
                session.Commit();
            }
            catch (Exception e)
            {
                if (session != null)
                {
                    session.Rollback();
                }
            }
            finally
            {
                if (session != null)
                {
                    session.Close();
                }
            }
        }
    }
}