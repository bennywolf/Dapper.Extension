using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    /// <summary>
    /// 会话异常
    /// 乐观锁更新失败会抛出此异常
    /// </summary>
    public class SessionException:Exception
    {
        public SessionException()
        {

        }
        public SessionException(string message):base(message)
        {

        }
    }
}
