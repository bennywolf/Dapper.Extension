using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 购物车BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_shop_car")]
	public class T_SHOP_CAR
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 购物车CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SC_CODE",false)]
        public string ScCode { get; set; }
        /// <summary>
        /// 规格
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PS_CODE",false)]
        public string PsCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("PR_JSON",false)]
        public string PrJson { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("PS_JSON",false)]
        public string PsJson { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("PS_COUNT",false)]
        public int? PsCount { get; set; }
        /// <summary>
        /// 是否团购
        /// Type:int(18) IsNull:YES Default:null
        /// </summary>
        [Column("IS_GROUP",false)]
        public int? IsGroup { get; set; }
        /// <summary>
        /// 团购结束时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("GROUP_TIME",false)]
        public DateTime? GroupTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

