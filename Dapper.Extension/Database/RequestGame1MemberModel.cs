using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：用户每日抽奖次数BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestGame1MemberModel : RequstModel
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
        public string GmCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 
        /// Type:date IsNull:YES Default:null
        /// </summary>
        public DateTime? CountUpdate { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_GAME1_MEMBER GetEntity()
		{
			return new T_GAME1_MEMBER()
			{
				Id = this.Id,
				GmCode = this.GmCode,
				MeCode = this.MeCode,
				Count = this.Count,
				CountUpdate = this.CountUpdate,
				Version = this.Version,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

