 #Dapper.Extension

      //第一种开发模式：事物交由事物管理器执行
      [TestMethod]
      public void TestMethod1()
      {
          //MVC项目启动时向容器注入Servce：Aop+Ioc
          /*
           * 容器功能：
           *  1.完成业务方法事物自动提交回滚
           *  2.全局异常拦截，日志记录事物会话SQL，参数记录等等，
           * 事物传播行为：
           *  1.一个Service层的所有方法在一起互调使用一个事物
           *  2.一个Service层调用另一个Service，请手动将当前Serivce事务回话向下传递，否则将认为在新的事物中执行 
           *  3.Service事物提交原则是如果不抛出异常则提交，也可以根据业务手动调用Session.Rollback()完成回滚
           */
          ServiceContainer.Builder(c =>
          {
              c.Register<Service>();
              //c.Register<Service2>();//多个请这样注册
          });
          //从容器中解析出Service
          var service = ServiceContainer.Resolve<Service>();
          service.test();
      }
