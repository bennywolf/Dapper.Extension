using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 订单售后BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestShopOrderAfterModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SaCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SoCode { get; set; }
        /// <summary>
        /// 商户订单号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string TradeNo { get; set; }
        /// <summary>
        /// 售后原因描述
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string UsContent { get; set; }
        /// <summary>
        /// 用户上传截图
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string UsImages { get; set; }
        /// <summary>
        /// 申请时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UsTime { get; set; }
        /// <summary>
        /// 商家处理结果
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string BsContent { get; set; }
        /// <summary>
        /// 商家上传图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string BsImages { get; set; }
        /// <summary>
        /// 处理时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? BsTime { get; set; }
        /// <summary>
        /// 0未处理,1处理中,2已解决
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SHOP_ORDER_AFTER GetEntity()
		{
			return new T_SHOP_ORDER_AFTER()
			{
				Id = this.Id,
				SaCode = this.SaCode,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				SoCode = this.SoCode,
				TradeNo = this.TradeNo,
				UsContent = this.UsContent,
				UsImages = this.UsImages,
				UsTime = this.UsTime,
				BsContent = this.BsContent,
				BsImages = this.BsImages,
				BsTime = this.BsTime,
				Status = this.Status,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

