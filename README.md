 #Dapper.Extension

using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.Library.File;
using Mammothcode.Business.Services;
using Dapper.Extension.Model;
using Dapper.Extension;
using Autofac;
using Common.Library.Data;
using System.Collections.Generic;
using System.Data;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        #region 创建容器
        public IContainer Container { get; set; }
        /// <summary>
        /// 启动时注册服务
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            Container = AppContainer.Builder("Mammothcode.Business");
        }
        [TestCleanup]
        public void Dispose()
        {
            Container.Dispose();
        }
        /// <summary>
        /// 解析组件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Resolve<T>()
        {
            return AppContainer.Resolve<T>();
        }
        #endregion


        [TestMethod]
        public void TestMethod1()
        {
            //获取一个代理会话
            var session = SessionFactory.GetSession(true);
            //开启事物/关闭自动提交
            session.Open(true);
            var row = 0;
            //Inset
            row = session.From<T_SYSTEM_MENUS>().Insert(new T_SYSTEM_MENUS()
            {
                IsChild = 1,
                MuName = "Main",
            });

            //Update:根据主键字段更新,及更新Id1==3的
            session.From<T_SYSTEM_MENUS>().Update(new T_SYSTEM_MENUS()
            {
                Id = 3,
                MuName = "Root"
            });
            //更新所有字节点的MuName和MuDesc为Child
            session.From<T_SYSTEM_MENUS>()
                .Set(s => s.MuName, "Child")
                .Set(s => s.MuDesc, "Child")
                .Where(s => s.IsChild == 1)
                .Update();

            //Delete:根据Id删除，及删除Id==2的
            row = session.From<T_SYSTEM_MENUS>().Delete(new T_SYSTEM_MENUS()
            {
                Id = 2
            });
            //Delete:删除所有子节点
            row = session.From<T_SYSTEM_MENUS>()
                .Where(s => s.IsChild == 1)
                .Delete();

            //Select ALL:查询菜单子节点并且id在1~23之间的,按Id升序,Sort降序查第一页所有数据
            var list = session.From<T_SYSTEM_MENUS>()
                .Where(m => m.IsChild == 1 && m.Id.Between(1, 23) && m.MuType.In(new int[] { 1, 2, 3 }))
                .Asc(s => s.Id)
                .Desc(s => s.Sort)
                .Top(0, 10)
                .Select();

            //Select Single
            var entity = session.From<T_SYSTEM_MENUS>()
               .Where(m => m.IsChild == 1)
               .Asc(s => s.Id)
               .Desc(s => s.Sort)
               .Single();
            
            //dynamic Select 动态查询
            //前台请求参数:分页
            var req = new SystemMenusModel()
            {
                PageIndex = 1,
                PageSize = 10,
                MuName = "cc"
            };
            //分页查询:必须条件IsChild==1，动态条件MuName不为空则MuName必须包含cc
            req.Query
                .And(s => s.IsChild == 1)
                .AndThen(req.MuName != null, s => s.MuName.Like(req.MuName));
            list = session.From<T_SYSTEM_MENUS>()
                .Where(req.Query)
                .Asc(s => s.MuType)
                .SkipPage(req)
                .Select();

            //多表链接
            session.From<Student_Coures>()
                .Where(s => s.Sid > 10)
                .SelectMap(s=>new//由于a.id无法映射到Id自动，通过SelectMap映射查询可以得到 a.id as id（注解+属性）
                {
                    s.Id,
                    s.Date,
                    s.CourseNAme,
                    s.StudentName
                });
            session.Commit();
            session.Rollback();//应该写在catch里
            session.Close();//应该写在finally里
        }

        [Table("student as a join course as b on a.id=b.sid")]//灵活的完成表链接
        public class Student_Coures
        {
            [Column("a.id")]
            public int Id { get; set; }
            [Column("b.id")]
            public int Sid { get; set; }
            [Column("a.name")]
            public string StudentName { get; set; }
            [Column("b.name")]
            public int CourseNAme { get; set; }
            [Column("DATE(a.createtime)")]//灵活的调用mysql函数
            public string Date { get; set; }
        }
    }
   
   
}
