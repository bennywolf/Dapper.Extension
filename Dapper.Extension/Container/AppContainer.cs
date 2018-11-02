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
        private static ContainerBuilder builder = new ContainerBuilder();
        public static void Builder(Action<AppContainer> action)
        {
            action(new AppContainer());
            //注册拦截器
            builder.RegisterType<TransactionIntercept>()
                .SingleInstance();
            //注册日志
            builder.Register(c=>LogManager.GetLogger("*"))
                .As<ILogger>()
                .SingleInstance();
            Container = builder.Build();
        }

        public void Register<T>()
        {
            //注册组件，并启用事物拦截器
            builder.RegisterType<T>().AsSelf()
              .PropertiesAutowired()
              .InstancePerLifetimeScope()
              .InterceptedBy(typeof(TransactionIntercept))
              .EnableClassInterceptors();
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