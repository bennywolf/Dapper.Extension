using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户收款方式BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberBankModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 收款CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MbCode { get; set; }
        /// <summary>
        /// 收款银行
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MbName { get; set; }
        /// <summary>
        /// 银行账号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MbAccount { get; set; }
        /// <summary>
        /// 真实姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MbRealName { get; set; }
        /// <summary>
        /// 0微信,1银行
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MbType { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 电话
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MbMobile { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER_BANK GetEntity()
		{
			return new T_MEMBER_BANK()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MbCode = this.MbCode,
				MbName = this.MbName,
				MbAccount = this.MbAccount,
				MbRealName = this.MbRealName,
				MbType = this.MbType,
				CreateTime = this.CreateTime,
				MbMobile = this.MbMobile,
 
			};
		}
	}
}

