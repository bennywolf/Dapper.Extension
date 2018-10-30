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

        public void create()
        {
            Session.From<STUDENT>().Insert(new STUDENT());
        }
       
    }
}
