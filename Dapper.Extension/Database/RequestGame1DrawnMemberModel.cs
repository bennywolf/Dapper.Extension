using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：参与记录BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestGame1DrawnMemberModel : RequstModel
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
        public string GdCode { get; set; }
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
        /// 期数
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string GaCode { get; set; }
        /// <summary>
        /// 期数
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string GaName { get; set; }
        /// <summary>
        /// 奖品
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string GpCode { get; set; }
        /// <summary>
        /// 奖品
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? GpType { get; set; }
        /// <summary>
        /// 奖品名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string GpName { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(10,0) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_GAME1_DRAWN_MEMBER GetEntity()
		{
			return new T_GAME1_DRAWN_MEMBER()
			{
				Id = this.Id,
				GdCode = this.GdCode,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				GaCode = this.GaCode,
				GaName = this.GaName,
				GpCode = this.GpCode,
				GpType = this.GpType,
				GpName = this.GpName,
				Amount = this.Amount,
				CoCode = this.CoCode,
				Image = this.Image,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

