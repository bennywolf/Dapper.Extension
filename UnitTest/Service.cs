using Dapper.Extension;
using Dapper.Extension.Model;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Service : SeviceBase
    {
        public ISession Session { get; set; }
        public ILogger Logger { get ; set ; }
    }
}
