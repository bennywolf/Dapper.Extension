using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberModel : RequstModel
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
        public string MeCode { get; set; }
        /// <summary>
        /// 0男,1女
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MeGander { get; set; }
        /// <summary>
        /// 联系电话
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeMobile { get; set; }
        /// <summary>
        /// 昵称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string MeOpenid { get; set; }
        /// <summary>
        /// 头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 推荐人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeFacode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string FaName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string FaHeadPhoto { get; set; }
        /// <summary>
        /// 可用余额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? MeBalAmount { get; set; }
        /// <summary>
        /// 提现冻结金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? MeFreAmount { get; set; }
        /// <summary>
        /// 分销盈利金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? MeSalAmount { get; set; }
        /// <summary>
        /// 分销待收益金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? MeTmpSalAmount { get; set; }
        /// <summary>
        /// 订单数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MeOrdCount { get; set; }
        /// <summary>
        /// 所有下级订单笔数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MeSubOrdCount { get; set; }
        /// <summary>
        /// 子用户数,推荐的用户数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MeSubCount { get; set; }
        /// <summary>
        /// 用户二维码
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string QrCode { get; set; }
        /// <summary>
        /// 版本
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 提货人姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string DeliverName { get; set; }
        /// <summary>
        /// 提货手机号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string DeliverMobile { get; set; }
        /// <summary>
        /// 是否代理：0不是，1是
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsProxy { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PxCode { get; set; }
        /// <summary>
        /// 分销转换率
        /// Type:decimal(10,4) IsNull:YES Default:null
        /// </summary>
        public decimal? SalesRate { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER GetEntity()
		{
			return new T_MEMBER()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MeGander = this.MeGander,
				MeMobile = this.MeMobile,
				MeName = this.MeName,
				MeOpenid = this.MeOpenid,
				MeHeadPhoto = this.MeHeadPhoto,
				MeFacode = this.MeFacode,
				FaName = this.FaName,
				FaHeadPhoto = this.FaHeadPhoto,
				MeBalAmount = this.MeBalAmount,
				MeFreAmount = this.MeFreAmount,
				MeSalAmount = this.MeSalAmount,
				MeTmpSalAmount = this.MeTmpSalAmount,
				MeOrdCount = this.MeOrdCount,
				MeSubOrdCount = this.MeSubOrdCount,
				MeSubCount = this.MeSubCount,
				QrCode = this.QrCode,
				Version = this.Version,
				CreateTime = this.CreateTime,
				DeliverName = this.DeliverName,
				DeliverMobile = this.DeliverMobile,
				IsProxy = this.IsProxy,
				PxCode = this.PxCode,
				SalesRate = this.SalesRate,
 
			};
		}
	}
}

