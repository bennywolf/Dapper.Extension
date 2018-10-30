using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 购物自提BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_shop_deliver")]
	public class T_SHOP_DELIVER
	{
        /// <summary>
        /// 自增ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SD_CODE",false)]
        public string SdCode { get; set; }
        /// <summary>
        /// 自提点名称
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("ADDR_DESC",false)]
        public string AddrDesc { get; set; }
        /// <summary>
        /// 自提点详细地址
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("ADDR_DETAIL",false)]
        public string AddrDetail { get; set; }
        /// <summary>
        /// 自提点联系人姓名
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("US_NAME",false)]
        public string UsName { get; set; }
        /// <summary>
        /// 自提点联系人手机号
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("US_MOBILE",false)]
        public string UsMobile { get; set; }
        /// <summary>
        /// 自提点经度
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("LOC_X",false)]
        public string LocX { get; set; }
        /// <summary>
        /// 自提点纬度
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("LOC_Y",false)]
        public string LocY { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SORT",false)]
        public int? Sort { get; set; }
   
	}
}

