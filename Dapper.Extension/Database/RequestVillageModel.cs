using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 小区表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestVillageModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string ViCode { get; set; }
        /// <summary>
        /// 名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 详细地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 精度
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PointX { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PointY { get; set; }
        /// <summary>
        /// 省
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string Provi { get; set; }
        /// <summary>
        /// 市
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_VILLAGE GetEntity()
		{
			return new T_VILLAGE()
			{
				Id = this.Id,
				ViCode = this.ViCode,
				Name = this.Name,
				Address = this.Address,
				PointX = this.PointX,
				PointY = this.PointY,
				Provi = this.Provi,
				City = this.City,
				Area = this.Area,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

