using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 代理BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_proxy")]
	public class T_PROXY
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        [Column("ID",false)]
        public int? Id { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PX_CODE",false)]
        public string PxCode { get; set; }
        /// <summary>
        /// 二维码
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("QR_CODE",false)]
        public string QrCode { get; set; }
        /// <summary>
        /// 团名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PX_TITLE",false)]
        public string PxTitle { get; set; }
        /// <summary>
        /// 代理人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PX_NAME",false)]
        public string PxName { get; set; }
        /// <summary>
        /// 经度
        /// Type:varchar(11) IsNull:YES Default:null
        /// </summary>
        [Column("POINT_X",false)]
        public string PointX { get; set; }
        /// <summary>
        /// 纬度
        /// Type:varchar(11) IsNull:YES Default:null
        /// </summary>
        [Column("POINT_Y",false)]
        public string PointY { get; set; }
        /// <summary>
        /// 是否小区
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_VILLAGE",false)]
        public int? IsVillage { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("VI_CODE",false)]
        public string ViCode { get; set; }
        /// <summary>
        /// 详细地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ADDRESS",false)]
        public string Address { get; set; }
        /// <summary>
        /// 手机号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MOBILE",false)]
        public string Mobile { get; set; }
        /// <summary>
        /// 微信账号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("WECHAT_ACC",false)]
        public string WechatAcc { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 用户头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 用户名
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
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
        /// <summary>
        /// 0申请中，1审核通过，2审核不通过
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATE",false)]
        public int? State { get; set; }
   
	}
}

