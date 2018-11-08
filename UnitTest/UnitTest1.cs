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
<<<<<<< HEAD
            var bit = new Bitmap(Image.FromFile("D:\\aa.jpg"),500,500);
            var grap = Graphics.FromImage(bit);

            var path = RoundRect.GetRoundRectPath(new System.Drawing.Rectangle(0,0,500,500),20);
            var brush = new SolidBrush(Color.Cornsilk);
            grap.FillPath(brush, path);
            grap.Save();
            bit.Save("D:\\fsaf.png");
=======
<<<<<<< HEAD
            while (true)
            {
                Console.WriteLine("aa");
            }
=======
            var session = SessionFactory.GetSession(true);
            var student = session.From<STUDENT>().Where(s=>s.Age>EStudent.Age.ToInt()).Select();
>>>>>>> 7d68c7e31b665e65cdf39c2d1c77337e29f1ecb4
>>>>>>> 9d2343d292165a41ce683617ae1189646b0011a8
        }


    }
    public enum EStudent
    {
        Age=20,
        Sex=50
    }
  

   
}
