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
            session.Open(true);

            var row = session.From<STUDENT>().Insert(new STUDENT() {
                Age=25,
                CreateTime=DateTime.Now,
                Name="aaa",
                Version="fsdfagg",
            });

            var entity = session.From<STUDENT>().Select();

            row = session.From<STUDENT>().Delete(entity);

            row = session.From<STUDENT>().Set(s=>s.Name,"setsetle").Where(s=>s.Name== "aaa").Update();

            session.ToString();

            
        }

    }
   
}
