using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：转发记录表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestGame1ForwardModel : RequstModel
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
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string GaName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// 转发日期
        /// Type:date IsNull:YES Default:null
        /// </summary>
        public DateTime? ForwardDate { get; set; }
        /// <summary>
        /// 群ID
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_GAME1_FORWARD GetEntity()
		{
			return new T_GAME1_FORWARD()
			{
				Id = this.Id,
				GaCode = this.GaCode,
				GaName = this.GaName,
				MeCode = this.MeCode,
				GroupId = this.GroupId,
				ForwardDate = this.ForwardDate,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

