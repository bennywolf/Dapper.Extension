using Castle.DynamicProxy;
using System;

namespace Dapper.Extension
{
    /// <summary>
    /// 事物拦截器
    /// 
    /// 事务传播行为：
    ///     1.如果ISevice的实现类中的Session未初始化则将其初始化
    ///     2.只有virtua方法会被拦截，virtual方法之间不能互相调用</summary>
    public class TransactionIntercept : IInterceptor
    {
        /// <summary>
        /// 事务拦截器AOP
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {
            ISession session = null;
            try
            {
                #region 注入会话事物
                //如果目标对象实现了ISession接口则注入事物，自动提交回滚
                var target = invocation.InvocationTarget;
                if (target is SeviceBase)
                {
                    var dao = target as SeviceBase;
                    //事务传播行为，如果同一个Service则使用同一个事物
                    if (dao.Session==null)
                    {
                        //注入事务
                        session = SessionFactory.GetSession(true) ;
                        dao.Session = session;
                        session.Open(false);
                    }
                }
                #endregion

                #region 执行目标方法
                invocation.Proceed();
                #endregion

                #region 提交事物
                if (session!=null)
                {
                    session.Commit();
                }
                #endregion
            }
            catch (Exception e)
            {
                //回滚事物
                if (session != null)
                {
                    session.Rollback();
                }
                throw e;
            }
            finally
            {
                //关闭事物
                if (session != null)
                {
                    session.Close();
                }
            }
        }
        
    }
}