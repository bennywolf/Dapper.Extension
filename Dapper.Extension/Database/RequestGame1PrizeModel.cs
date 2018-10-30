using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：大转盘奖品BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestGame1PrizeModel : RequstModel
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
        public string GpCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string GaCode { get; set; }
        /// <summary>
        /// 奖品名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string GaName { get; set; }
        /// <summary>
        /// 奖品类型：0优惠券，1现金红包
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? GpType { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string GpName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoCode { get; set; }
        /// <summary>
        /// 概率
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Rate { get; set; }
        /// <summary>
        /// 上限数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Max { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 数据版本号
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string Version { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_GAME1_PRIZE GetEntity()
		{
			return new T_GAME1_PRIZE()
			{
				Id = this.Id,
				GpCode = this.GpCode,
				GaCode = this.GaCode,
				GaName = this.GaName,
				GpType = this.GpType,
				GpName = this.GpName,
				Image = this.Image,
				Amount = this.Amount,
				CoCode = this.CoCode,
				Rate = this.Rate,
				Max = this.Max,
				Sort = this.Sort,
				Version = this.Version,
 
			};
		}
	}
}

