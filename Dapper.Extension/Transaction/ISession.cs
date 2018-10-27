using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    public interface ISevice
    {
        DbSession Session { get; set; }
    }


    public class Sevice1 : ISevice
    {
       public DbSession Session { get; set; }

    }

    public class Sevice2 : ISevice
    {
        public Sevice1 sevice { get; set; }
        public DbSession Session { get; set; }
    }

}
