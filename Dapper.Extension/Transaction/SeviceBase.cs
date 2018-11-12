using NLog;
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
    public abstract class SeviceBase
    {
        /// <summary>
        /// 事务会话
        /// </summary>
        public ISession Session { get; set; }
        /// <summary>
        /// 日志工具
        /// </summary>
        public ILogger Logger { get; set; }
    }
}
