using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户收货地址BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member_address")]
	public class T_MEMBER_ADDRESS
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 用户
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 收货人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_NAME",false)]
        public string MaName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_CODE",false)]
        public string MaCode { get; set; }
        /// <summary>
        /// 收货人号码
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_MOBILE",false)]
        public string MaMobile { get; set; }
        /// <summary>
        /// 定位地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_POINT",false)]
        public string MaPoint { get; set; }
        /// <summary>
        /// 详细地址手动输入
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_DETAIL",false)]
        public string MaDetail { get; set; }
        /// <summary>
        /// 是否默认地址
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_DEFAULT",false)]
        public int? IsDefault { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 市
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_CITY",false)]
        public string MaCity { get; set; }
        /// <summary>
        /// 区
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_AREA",false)]
        public string MaArea { get; set; }
        /// <summary>
        /// 省
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_PROVI",false)]
        public string MaProvi { get; set; }
   
	}
}

