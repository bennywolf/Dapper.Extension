using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    public class DbCommand
    {
        public CommandType CommandType { get; set; }
        public string Command { get; set; }
        public dynamic Params { get; set; }
        public DateTime Time { get; set; }
    }
}
