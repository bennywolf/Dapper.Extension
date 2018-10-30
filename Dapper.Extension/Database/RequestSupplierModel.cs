using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 供应商BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestSupplierModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 供应商CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SuCode { get; set; }
        /// <summary>
        /// 名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SuName { get; set; }
        /// <summary>
        /// 地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SuAddress { get; set; }
        /// <summary>
        /// 联系人
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SuLinkmen { get; set; }
        /// <summary>
        /// 描述
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SuDesc { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SUPPLIER GetEntity()
		{
			return new T_SUPPLIER()
			{
				Id = this.Id,
				SuCode = this.SuCode,
				SuName = this.SuName,
				SuAddress = this.SuAddress,
				SuLinkmen = this.SuLinkmen,
				SuDesc = this.SuDesc,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

