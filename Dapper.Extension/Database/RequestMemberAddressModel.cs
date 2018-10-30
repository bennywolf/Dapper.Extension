using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户收货地址BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberAddressModel : RequstModel
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
        /// 收货人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaCode { get; set; }
        /// <summary>
        /// 收货人号码
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaMobile { get; set; }
        /// <summary>
        /// 定位地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaPoint { get; set; }
        /// <summary>
        /// 详细地址手动输入
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaDetail { get; set; }
        /// <summary>
        /// 是否默认地址
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsDefault { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 市
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaCity { get; set; }
        /// <summary>
        /// 区
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaArea { get; set; }
        /// <summary>
        /// 省
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaProvi { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER_ADDRESS GetEntity()
		{
			return new T_MEMBER_ADDRESS()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MaName = this.MaName,
				MaCode = this.MaCode,
				MaMobile = this.MaMobile,
				MaPoint = this.MaPoint,
				MaDetail = this.MaDetail,
				IsDefault = this.IsDefault,
				CreateTime = this.CreateTime,
				MaCity = this.MaCity,
				MaArea = this.MaArea,
				MaProvi = this.MaProvi,
 
			};
		}
	}
}

