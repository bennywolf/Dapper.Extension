using Autofac;
using Autofac.Extras.DynamicProxy;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dapper.Extension
{
    public class AppContainer
    {
        public static IContainer Container { get; set; }
        /// <summary>
        /// 注册服务到容器
        /// </summary>
        /// <param name="assembly">程序集完全限定命</param>
        /// <returns></returns>
        public static IContainer Builder(string assembly)
        {
            ContainerBuilder builder = new ContainerBuilder();

            //注册拦截器
            builder.RegisterType<TransactionIntercept>()
                    .WithProperty("Logger", LogManager.GetLogger("intercept"))
                    .SingleInstance();

            //注册组件服务
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load(assembly))
                    .Where(t => t.BaseType == typeof(SeviceBase))
                    .WithProperty("Logger", LogManager.GetLogger("service"))
                    .InstancePerLifetimeScope()
                    .InterceptedBy(typeof(TransactionIntercept))
                    .EnableClassInterceptors();

            return (Container = builder.Build());
        }

        public static T Resolve<T>()
        {
            T instance = default(T);
            using (var scope = Container.BeginLifetimeScope())
            {
                instance = scope.Resolve<T>();
            }
            return instance;
        }

    }
}