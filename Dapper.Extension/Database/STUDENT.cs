using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 学生表BASE TABLE
	/// 更新时间：2018-10-31 10:21:43
    /// </summary>
    [Table("student")]
	public class STUDENT
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
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
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

