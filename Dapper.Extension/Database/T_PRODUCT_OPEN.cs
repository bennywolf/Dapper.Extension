using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 商品团购开放设置BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_product_open")]
	public class T_PRODUCT_OPEN
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PRO_CODE",false)]
        public string ProCode { get; set; }
        /// <summary>
        /// 商品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PR_CODE",false)]
        public string PrCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PX_CODE",false)]
        public string PxCode { get; set; }
        /// <summary>
        /// 是否完全开放
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_OPEN",false)]
        public int? IsOpen { get; set; }
        /// <summary>
        /// 开放时间
        /// Type:date IsNull:YES Default:null
        /// </summary>
        [Column("OPEN_TIME",false)]
        public DateTime? OpenTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

