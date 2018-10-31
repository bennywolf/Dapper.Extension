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

            var session = SessionFactory.GetSession(false);
            Stopwatch stop = new Stopwatch();
            stop.Start();
            session.Open(false);
            var list = session.From<STUDENT>().Select();
            foreach (var item in list)
            {
                item.CreateTime = DateTime.Now;
                item.Name = "dapperaaa";
            }
            session.From<STUDENT>().Update(list);
            session.Commit();
            stop.Stop();
            Debug.WriteLine(stop.ElapsedMilliseconds);
        }

    }
   
}
