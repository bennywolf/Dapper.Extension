using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 提现记录表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberWithdrawModel : RequstModel
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
        /// 用户名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 用户头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 银行卡CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MbCode { get; set; }
        /// <summary>
        /// 银行名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MbName { get; set; }
        /// <summary>
        /// 账号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MbAccount { get; set; }
        /// <summary>
        /// 真实姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MbRealName { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MbType { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MbMobile { get; set; }
        /// <summary>
        /// 提现CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MwCode { get; set; }
        /// <summary>
        /// 提现金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 0,1,2(初始，通过，作废)
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 审核时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CheckTime { get; set; }
        /// <summary>
        /// 审核原因
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string CheckDesc { get; set; }
        /// <summary>
        /// 提现时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER_WITHDRAW GetEntity()
		{
			return new T_MEMBER_WITHDRAW()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				MbCode = this.MbCode,
				MbName = this.MbName,
				MbAccount = this.MbAccount,
				MbRealName = this.MbRealName,
				MbType = this.MbType,
				MbMobile = this.MbMobile,
				MwCode = this.MwCode,
				Amount = this.Amount,
				Status = this.Status,
				CheckTime = this.CheckTime,
				CheckDesc = this.CheckDesc,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

