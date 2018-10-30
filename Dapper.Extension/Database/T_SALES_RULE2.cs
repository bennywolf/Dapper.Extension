using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 分销二级BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_sales_rule2")]
	public class T_SALES_RULE2
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
        [Column("COUNT",false)]
        public int? Count { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(10,4) IsNull:YES Default:null
        /// </summary>
        [Column("RATE",false)]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("DESCRIPT",false)]
        public string Descript { get; set; }
   
	}
}

