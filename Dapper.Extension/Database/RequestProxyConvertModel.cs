using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 转化记录BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestProxyConvertModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 团CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PxCode { get; set; }
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
        /// 转化次数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? ConCount { get; set; }
        /// <summary>
        /// 查看次数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? BroCount { get; set; }
        /// <summary>
        /// 第一次转化时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UpdateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PROXY_CONVERT GetEntity()
		{
			return new T_PROXY_CONVERT()
			{
				Id = this.Id,
				PxCode = this.PxCode,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				ConCount = this.ConCount,
				BroCount = this.BroCount,
				CreateTime = this.CreateTime,
				UpdateTime = this.UpdateTime,
 
			};
		}
	}
}

