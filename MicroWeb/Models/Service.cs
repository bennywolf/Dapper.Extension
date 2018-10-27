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
        public DbSession Session { get ; set ; }

        public virtual void CreateOrder(RequestMemberModel req)
        {
            var entity = req.GetEntity();
            Session.From<T_MEMBER>().Insert(entity);
        }
    }

}