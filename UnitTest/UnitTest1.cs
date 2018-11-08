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
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
<<<<<<< HEAD
            while (true)
            {
                Console.WriteLine("aa");
            }
=======
            var session = SessionFactory.GetSession(true);
            var student = session.From<STUDENT>().Where(s=>s.Age>EStudent.Age.ToInt()).Select();
>>>>>>> 7d68c7e31b665e65cdf39c2d1c77337e29f1ecb4
        }


    }
    public enum EStudent
    {
        Age=20,
        Sex=50
    }
  

   
}
