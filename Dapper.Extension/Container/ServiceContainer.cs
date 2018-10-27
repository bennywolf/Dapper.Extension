using Autofac;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dapper.Extension
{
    public class ServiceContainer
    {
        public static IContainer Container { get; set; }
        private static ContainerBuilder builder = new ContainerBuilder();
        public static void Builder(Action<ServiceContainer> action)
        {
            action(new ServiceContainer());
            builder.RegisterType<TransactionIntercept>()
                .SingleInstance();
            Container = builder.Build();
        }

        public void Register<T>()
        {
            //注册组件，并启用事物拦截器
            builder.RegisterType<T>().AsSelf()
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