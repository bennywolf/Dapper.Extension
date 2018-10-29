using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// VIEWVIEW
	/// 更新时间：2018-10-29 12:01:23
    /// </summary>
    [Table("vstudent")]
	public class VSTUDENT
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        [Column("ID",false)]
        public int? Id { get; set; }
        /// <summary>
        /// 姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("NAME",false)]
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("AGE",false)]
        public int? Age { get; set; }
   
	}
}

