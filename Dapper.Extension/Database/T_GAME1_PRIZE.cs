using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：大转盘奖品BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_game1_prize")]
	public class T_GAME1_PRIZE
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
        [Column("GP_CODE",false)]
        public string GpCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("GA_CODE",false)]
        public string GaCode { get; set; }
        /// <summary>
        /// 奖品名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("GA_NAME",false)]
        public string GaName { get; set; }
        /// <summary>
        /// 奖品类型：0优惠券，1现金红包
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("GP_TYPE",false)]
        public int? GpType { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("GP_NAME",false)]
        public string GpName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("IMAGE",false)]
        public string Image { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CO_CODE",false)]
        public string CoCode { get; set; }
        /// <summary>
        /// 概率
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("RATE",false)]
        public int? Rate { get; set; }
        /// <summary>
        /// 上限数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MAX",false)]
        public int? Max { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SORT",false)]
        public int? Sort { get; set; }
        /// <summary>
        /// 数据版本号
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("VERSION",false)]
        public string Version { get; set; }
   
	}
}

