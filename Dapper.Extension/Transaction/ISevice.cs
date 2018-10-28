using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    /// <summary>
    /// 业务层顶级接口
    /// </summary>
    public interface ISevice
    {
        ISession Session { get; set; }
    }
}
