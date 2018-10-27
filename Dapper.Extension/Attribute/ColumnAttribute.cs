using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute:Attribute
    {
        public string Name { get; set; }
        public bool Identity { get; set; }
        public ColumnAttribute()
        {

        }
        public ColumnAttribute(string name,bool identity=false)
        {
            this.Name = name;
            this.Identity = identity;
        }
    }
}
