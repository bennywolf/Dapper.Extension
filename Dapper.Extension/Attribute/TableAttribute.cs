using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute:Attribute
    {
        public string Name { get; set; }
        public TableAttribute()
        {

        }
        public TableAttribute(string name)
        {
            this.Name = name;
        }
    }
}
