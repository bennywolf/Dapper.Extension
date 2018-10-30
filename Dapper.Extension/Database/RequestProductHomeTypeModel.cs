using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 产品分类BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestProductHomeTypeModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PhtCode { get; set; }
        /// <summary>
        /// 类别名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PhtName { get; set; }
        /// <summary>
        /// 类别图标
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PhtImage { get; set; }
        /// <summary>
        /// 顺序
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PhtSort { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PRODUCT_HOME_TYPE GetEntity()
		{
			return new T_PRODUCT_HOME_TYPE()
			{
				Id = this.Id,
				PhtCode = this.PhtCode,
				PhtName = this.PhtName,
				PhtImage = this.PhtImage,
				PhtSort = this.PhtSort,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

