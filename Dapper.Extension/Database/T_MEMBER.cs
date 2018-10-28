using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// BASE TABLE
	/// 更新时间：2018-10-28 14:58:16
    /// </summary>
    [Table("t_member")]
	public class T_MEMBER
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("AGE",false)]
        public int? Age { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("NAME",false)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("REMARK",false)]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

