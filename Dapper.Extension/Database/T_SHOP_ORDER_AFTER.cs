using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 订单售后BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_shop_order_after")]
	public class T_SHOP_ORDER_AFTER
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
        [Column("SA_CODE",false)]
        public string SaCode { get; set; }
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
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
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
        [Column("SO_CODE",false)]
        public string SoCode { get; set; }
        /// <summary>
        /// 商户订单号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("TRADE_NO",false)]
        public string TradeNo { get; set; }
        /// <summary>
        /// 售后原因描述
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("US_CONTENT",false)]
        public string UsContent { get; set; }
        /// <summary>
        /// 用户上传截图
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("US_IMAGES",false)]
        public string UsImages { get; set; }
        /// <summary>
        /// 申请时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("US_TIME",false)]
        public DateTime? UsTime { get; set; }
        /// <summary>
        /// 商家处理结果
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("BS_CONTENT",false)]
        public string BsContent { get; set; }
        /// <summary>
        /// 商家上传图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("BS_IMAGES",false)]
        public string BsImages { get; set; }
        /// <summary>
        /// 处理时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("BS_TIME",false)]
        public DateTime? BsTime { get; set; }
        /// <summary>
        /// 0未处理,1处理中,2已解决
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATUS",false)]
        public int? Status { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

