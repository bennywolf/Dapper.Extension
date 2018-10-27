 [TestClass]
    public class UnitTest1
    {
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
        //第二种开发模式：自行编码管理事物
        [TestMethod]
        public void TestMethod2()
        {
            //设置自动提交为false
            DbSession session = SessionFactory.GetSession(true);
            session.From<T_MEMBER>().Insert(new T_MEMBER()
            {
                Balance = 20,
                Comment = "测试手动提交",
                CreateTime = DateTime.Now,
                MeAge = 20,
            });
            //session.Commit();
        }
        //
        public void TestMethod3()
        {
            DbSession session = SessionFactory.GetSession(true);
            //一：插入
            session.From<T_MEMBER>().Insert(new T_MEMBER()
            {
                Balance = 20,
                Comment = "测试手动提交",
                CreateTime = DateTime.Now,
                MeAge = 20,
            });
            //批量插入,即使list为null，或者Count为0也不会抛出异常
            var list = new List<T_MEMBER>();
            session.From<T_MEMBER>().Insert(list);

            //二：修改指定字段
            session.From<T_MEMBER>()
                .Set(s => s.Comment, "更新所有年龄小于30的")
                .Where(s => s.MeAge < 30)
                .Update();
            //根据标识修改对象
            var member = session.From<T_MEMBER>().Where(s => s.Id == 2).Single();
            session.From<T_MEMBER>().Update(member);
            //三：删除
            session.From<T_MEMBER>().Where(s => s.MeAge == 3 && s.MeCode.Like("cc")).Delete();
            //删除Id是1，2，3的
            session.From<T_MEMBER>().Where(s => s.Id.In(new int[] { 1, 2, 3 })).Delete();
            //四：查询
            session.From<T_MEMBER>().Where(s => s.Id.In(new int[] { 1, 2, 3 })).Select();
            //仅仅查询出MeCode
            list = session.From<T_MEMBER>().Where(s => s.Id.In(new int[] { 1, 2, 3 })).Select(s => s.MeCode);
           
            //动态Lamuda查询+分页
            var param = new { Age="",Balnce=30};
            var query = new SqlExpression<T_MEMBER>();
            query.Left();
            query.And(s=>s.Balance>30&&s.MeAge>20);
            query.Left();
            //当条件成立时执行
            query.AndThen(param.Age!=null,s=>s.MeAge==10);
            var total = 0;
            list = session.From<T_MEMBER>().Where(query).SkipPage(1,2,out total);
            //打印事物执行过程的SQL，级参数，请自行重写ToString
            Debug.Write(session.Commands);

        }