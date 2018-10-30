using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 代理BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestProxyModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PxCode { get; set; }
        /// <summary>
        /// 二维码
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string QrCode { get; set; }
        /// <summary>
        /// 团名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PxTitle { get; set; }
        /// <summary>
        /// 代理人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PxName { get; set; }
        /// <summary>
        /// 经度
        /// Type:varchar(11) IsNull:YES Default:null
        /// </summary>
        public string PointX { get; set; }
        /// <summary>
        /// 纬度
        /// Type:varchar(11) IsNull:YES Default:null
        /// </summary>
        public string PointY { get; set; }
        /// <summary>
        /// 是否小区
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsVillage { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string ViCode { get; set; }
        /// <summary>
        /// 详细地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 手机号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 微信账号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string WechatAcc { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 用户头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 用户名
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
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
        /// 0申请中，1审核通过，2审核不通过
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? State { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PROXY GetEntity()
		{
			return new T_PROXY()
			{
				Id = this.Id,
				PxCode = this.PxCode,
				QrCode = this.QrCode,
				PxTitle = this.PxTitle,
				PxName = this.PxName,
				PointX = this.PointX,
				PointY = this.PointY,
				IsVillage = this.IsVillage,
				ViCode = this.ViCode,
				Address = this.Address,
				Mobile = this.Mobile,
				WechatAcc = this.WechatAcc,
				MeCode = this.MeCode,
				MeHeadPhoto = this.MeHeadPhoto,
				MeName = this.MeName,
				CreateTime = this.CreateTime,
				CheckTime = this.CheckTime,
				State = this.State,
 
			};
		}
	}
}

