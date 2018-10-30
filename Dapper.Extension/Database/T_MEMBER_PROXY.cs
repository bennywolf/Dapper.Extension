using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member_proxy")]
	public class T_MEMBER_PROXY
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
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
        /// <summary>
        /// 0申请中，1通过，2不通过
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATUS",false)]
        public int? Status { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MP_CODE",false)]
        public string MpCode { get; set; }
        /// <summary>
        /// 代理人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MP_NAME",false)]
        public string MpName { get; set; }
        /// <summary>
        /// 代理人电话
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MP_MOBILE",false)]
        public string MpMobile { get; set; }
        /// <summary>
        /// 城市
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("MP_CITY",false)]
        public string MpCity { get; set; }
        /// <summary>
        /// 详细地址
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("MP_ADDRESS",false)]
        public string MpAddress { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 审核时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CHECK_TIME",false)]
        public DateTime? CheckTime { get; set; }
   
	}
}

