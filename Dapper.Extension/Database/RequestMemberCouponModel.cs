using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户优惠券BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberCouponModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 用户
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 用户优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string McCode { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoDesc { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string CoTitle { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? CoType { get; set; }
        /// <summary>
        /// 是否使用1是，0不是
        /// Type:int(50) IsNull:YES Default:null
        /// </summary>
        public int? IsUse { get; set; }
        /// <summary>
        /// 最低使用金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? LowAmout { get; set; }
        /// <summary>
        /// 优惠券金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? DisAmout { get; set; }
        /// <summary>
        /// 使用时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UseTime { get; set; }
        /// <summary>
        /// 获取时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? GetTime { get; set; }
        /// <summary>
        /// 0购物,1注册
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? GetType { get; set; }
        /// <summary>
        /// 失效时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? ExpiryTime { get; set; }
        /// <summary>
        /// 获取该券的标识CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string GetCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER_COUPON GetEntity()
		{
			return new T_MEMBER_COUPON()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				McCode = this.McCode,
				CoCode = this.CoCode,
				CoDesc = this.CoDesc,
				CoTitle = this.CoTitle,
				CoType = this.CoType,
				IsUse = this.IsUse,
				LowAmout = this.LowAmout,
				DisAmout = this.DisAmout,
				UseTime = this.UseTime,
				GetTime = this.GetTime,
				GetType = this.GetType,
				ExpiryTime = this.ExpiryTime,
				GetCode = this.GetCode,
				PrCode = this.PrCode,
 
			};
		}
	}
}

