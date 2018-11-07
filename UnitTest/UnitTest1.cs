using Common.Library.File;
using Common.Library.Web;
using Dapper.Extension;
using Dapper.Extension.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var table = new DataTable("name");
            table.Columns.Add("姓名", typeof(string));
            table.Columns.Add("年龄", typeof(int));
            table.Columns.Add("性别", typeof(string));
            var row = table.NewRow();
            row["姓名"] = "李四";
            row["年龄"] = 20;
            row["性别"] = "男";
            table.Rows.Add(row);
            row = table.NewRow();
            row["姓名"] = "李八";
            row["年龄"] = 21;
            row["性别"] = "女";
            table.Rows.Add(row);
            var a = ExcelUtil.Read("D:\\aa.xls",0,1);
        }

    }
   
}
