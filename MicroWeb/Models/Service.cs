using Dapper.Extension;
using Dapper.Extension.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroWeb.Models
{
    public class Service : ISevice
    {
        public ISession Session { get ; set ; }

        /// <summary>
        /// virtual是会被事物管理器拦截的
        /// virtual之间不能互相调用
        /// </summary>
        /// <param name="req"></param>
        public virtual void CreateOrder(RequestMemberModel req)
        {
            var entity = req.GetEntity();
            var list = Session.From<T_MEMBER>().Select();
        }
    }

}