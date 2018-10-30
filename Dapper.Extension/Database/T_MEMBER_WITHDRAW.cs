using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 提现记录表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member_withdraw")]
	public class T_MEMBER_WITHDRAW
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 用户名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
        /// <summary>
        /// 用户头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 银行卡CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MB_CODE",false)]
        public string MbCode { get; set; }
        /// <summary>
        /// 银行名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MB_NAME",false)]
        public string MbName { get; set; }
        /// <summary>
        /// 账号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MB_ACCOUNT",false)]
        public string MbAccount { get; set; }
        /// <summary>
        /// 真实姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MB_REAL_NAME",false)]
        public string MbRealName { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MB_TYPE",false)]
        public int? MbType { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MB_MOBILE",false)]
        public string MbMobile { get; set; }
        /// <summary>
        /// 提现CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MW_CODE",false)]
        public string MwCode { get; set; }
        /// <summary>
        /// 提现金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 0,1,2(初始，通过，作废)
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATUS",false)]
        public int? Status { get; set; }
        /// <summary>
        /// 审核时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CHECK_TIME",false)]
        public DateTime? CheckTime { get; set; }
        /// <summary>
        /// 审核原因
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("CHECK_DESC",false)]
        public string CheckDesc { get; set; }
        /// <summary>
        /// 提现时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

