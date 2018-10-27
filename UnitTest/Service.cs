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
        public DbSession Session { get; set; }

        public virtual void test()
        {
            var total = 0;
            var list = Session.From<T_MEMBER>().Where(s=>s.MeAge>20).SkipPage(1,2,out total);
        }
    }
}
