using Common.Library.Data;
using Common.Library.File;
using Common.Library.Web;
using Dapper.Extension;
using Dapper.Extension.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var session = SessionFactory.GetSession(true);
            var entity = new STUDENT()
            {
                Name = "测试",
            };
            session.From<STUDENT>().InsertById(entity);

           
        }


    }
   
   
}
