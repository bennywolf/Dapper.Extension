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
            session.Open(false);
            var list = session.From<STUDENT>().Select();
            session.From<STUDENT>().Delete(list);
            session.Commit();
            Debug.WriteLine(111);
        }

    }
   
}
