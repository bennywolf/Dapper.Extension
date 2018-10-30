using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 订单详情BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestShopOrderDetailModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SoCode { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
        /// <summary>
        /// 产品名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 产品缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// 规格
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PsCode { get; set; }
        /// <summary>
        /// 规格
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 单价
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// 是否团购
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsGroup { get; set; }
        /// <summary>
        /// 单位
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 类别CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PtCode { get; set; }
        /// <summary>
        /// 类别名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PtName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PhtCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PhtName { get; set; }
        /// <summary>
        /// 订单产品详情
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SodCode { get; set; }
        /// <summary>
        /// 购买数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Num { get; set; }
        /// <summary>
        /// 小计
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? TolAmount { get; set; }
        /// <summary>
        /// 领取的优惠券
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoCode { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 是否评论
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsComment { get; set; }
        /// <summary>
        /// 供应商CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SuCode { get; set; }
        /// <summary>
        /// 供应商订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SosCode { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SHOP_ORDER_DETAIL GetEntity()
		{
			return new T_SHOP_ORDER_DETAIL()
			{
				Id = this.Id,
				SoCode = this.SoCode,
				PrCode = this.PrCode,
				Name = this.Name,
				Thumbnail = this.Thumbnail,
				PsCode = this.PsCode,
				Spec = this.Spec,
				Price = this.Price,
				IsGroup = this.IsGroup,
				Unit = this.Unit,
				PtCode = this.PtCode,
				PtName = this.PtName,
				PhtCode = this.PhtCode,
				PhtName = this.PhtName,
				SodCode = this.SodCode,
				Num = this.Num,
				TolAmount = this.TolAmount,
				CoCode = this.CoCode,
				CreateTime = this.CreateTime,
				IsComment = this.IsComment,
				SuCode = this.SuCode,
				SosCode = this.SosCode,
 
			};
		}
	}
}

