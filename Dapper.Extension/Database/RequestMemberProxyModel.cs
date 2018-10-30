using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberProxyModel : RequstModel
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
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 0申请中，1通过，2不通过
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MpCode { get; set; }
        /// <summary>
        /// 代理人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MpName { get; set; }
        /// <summary>
        /// 代理人电话
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MpMobile { get; set; }
        /// <summary>
        /// 城市
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string MpCity { get; set; }
        /// <summary>
        /// 详细地址
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string MpAddress { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 审核时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CheckTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER_PROXY GetEntity()
		{
			return new T_MEMBER_PROXY()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MeHeadPhoto = this.MeHeadPhoto,
				MeName = this.MeName,
				Status = this.Status,
				MpCode = this.MpCode,
				MpName = this.MpName,
				MpMobile = this.MpMobile,
				MpCity = this.MpCity,
				MpAddress = this.MpAddress,
				CreateTime = this.CreateTime,
				CheckTime = this.CheckTime,
 
			};
		}
	}
}

