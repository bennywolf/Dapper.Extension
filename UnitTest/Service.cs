using Dapper.Extension;
using Dapper.Extension.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Service : ISevice
    {
        public ISession Session { get; set; }

        public virtual void test()
        {
            var total = 0;
            var list = Session.From<T_MEMBER>().Where(s=>s.Age>20).SkipPage(1,2,out total);
            test1();
        }
        public void test1()
        {
            var total = 0;
            var list = Session.From<T_MEMBER>().Where(s => s.Age > 20).SkipPage(1, 2, out total);
        }
    }
}
