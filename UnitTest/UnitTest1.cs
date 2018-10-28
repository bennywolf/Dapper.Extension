using Dapper.Extension;
using Dapper.Extension.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {

            var session = SessionFactory.GetSession(true);
            var list = new List<T_MEMBER>();
            for (int i = 0; i < 15000; i++)
            {
                list.Add(new T_MEMBER()
                {
                    Age = i,
                    CreateTime = DateTime.Now,
                    Name = "测试" + i,
                    Remark = "测试15000数据插入"
                });
            }
        
          
             var row = session.From<T_MEMBER>().Insert(list);
            Console.WriteLine("");
         

         

        }
        [TestMethod]
        public void TestMethod2()
        {
            var session = SessionFactory.GetSession(true);
         
            var list = session.From<T_MEMBER>().Select();

            Console.WriteLine("");
        }
    }
}
