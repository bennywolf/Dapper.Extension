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
           

            Stopwatch watch = new Stopwatch();
            watch.Start();
            var session = SessionFactory.GetSession(true);
            var list = session.From<STUDENT>().Select();
            watch.Stop();
            Debug.WriteLine(watch.ElapsedMilliseconds);
        }

    }
   
}
