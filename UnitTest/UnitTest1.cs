using Dapper.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {

            var session = SessionFactory.GetSession(true);
            //CodeFirst
            //select SUM(AGE) as SumAge,CR_CODE as CrCode from student where age>20 group by CR_CODE having SUM(AGE)<40
            var list = session.From<Student>()
                .Where(s => s.Age > 20)
                .GroupBy(s => s.CrCode)
                .Having(s => s.SumAge < 40)
                .AsSelect(s => s.SumAge, s => s.CrCode);

            //select a.sid as id1,b.sid as id2 a.name as StudentName,b.name as SchoolName from student as a join school as b on a.sid=b.sid
            var list2 = session.From<StudentJonSchool>()
               .AsSelect(s => s.id1, s => s.id2, s => s.StudentName, s => s.SchoolName);

        }

    }
    /// <summary>
    /// 分组查询
    /// </summary>
    [Table("student")]//表名与类名同时，可以省略
    public class Student
    {
        [Column("CR_CODE")]
        public string CrCode { get; set; }
        public string Name { get; set; }
        [Column("SUM(AGE)")]//通过AsSelect 可以得到 SELECT SUM(AGE) AS SumAge,完成映射
        public int SumAge { get; set; }
        [Column("AGE")]//分组前AGE
        public int Age { get; set; }
    }
    [Table("student as a join school as b on a.sid=b.sid")]
    public class StudentJonSchool
    {

        [Column("a.Sid")]
        public int id1 { get; set; }
        [Column("b.Sid")]
        public int id2 { get; set; }
        [Column("a.Name")]
        public string StudentName { get; set; }
        [Column("b.Name")]
        public string SchoolName { get; set; }
    }
}
