using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：大转盘期数BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestGame1Model : RequstModel
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
        public string GaCode { get; set; }
        /// <summary>
        /// 奖品名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string GaName { get; set; }
        /// <summary>
        /// 规则
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string GaRule { get; set; }
        /// <summary>
        /// 说明
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string GaDesc { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsOn { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_GAME1 GetEntity()
		{
			return new T_GAME1()
			{
				Id = this.Id,
				GaCode = this.GaCode,
				GaName = this.GaName,
				GaRule = this.GaRule,
				GaDesc = this.GaDesc,
				IsOn = this.IsOn,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

