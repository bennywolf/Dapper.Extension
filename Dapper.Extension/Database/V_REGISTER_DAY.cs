using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// VIEWVIEW
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("v_register_day")]
	public class V_REGISTER_DAY
	{
        /// <summary>
        /// 
        /// Type:date IsNull:YES Default:null
        /// </summary>
        [Column("DAY",false)]
        public DateTime? Day { get; set; }
        /// <summary>
        /// 
        /// Type:bigint(21) IsNull:NO Default:0
        /// </summary>
        [Column("COUNT",false)]
        public int? Count { get; set; }
   
	}
}

