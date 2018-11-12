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
        public string Command { get; set; }
        public dynamic Param { get; set; }
        public DateTime Time { get; set; }
        public long Watch { get; set; }
        public string Text { get; set; }

        public string ParamToString()
        {
            var buffer = new StringBuilder();
            if (Param==null)
            {
                return string.Empty;
            }
            else if (Param is Dictionary<string,object>)
            {
                var fields = Param as Dictionary<string,object>;
                foreach (var key in fields.Keys)
                {
                    buffer.AppendFormat("SET {0} = '{1}';\n",key,fields[key]);
                }
            }
            else if (Param is IModel)
            {
                var model = Param as IModel;
                var fields = model.GetType().GetProperties();
                foreach (var item in fields)
                {
                    var value = item.GetValue(model);
                    buffer.AppendFormat("SET @{0} = {1};\n", item.Name, value == null ? "NULL" : "'" + value.ToString() + "'");
                }
            }
            else if(Param is IEnumerable<IModel>)
            {
                var list = Param as IEnumerable<IModel>;
                foreach (var item in list)
                {
                    var model = item as IModel;
                    var fields = model.GetType().GetProperties();
                    foreach (var field in fields)
                    {
                        buffer.AppendFormat("SET @{0} = '{1}';\n", field.Name, field.GetValue(model));
                    }
                }
            }
            return buffer.ToString();
        }
    }

}
