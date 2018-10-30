using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户收款方式BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member_bank")]
	public class T_MEMBER_BANK
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
        /// 收款CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MB_CODE",false)]
        public string MbCode { get; set; }
        /// <summary>
        /// 收款银行
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MB_NAME",false)]
        public string MbName { get; set; }
        /// <summary>
        /// 银行账号
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
        /// 0微信,1银行
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MB_TYPE",false)]
        public int? MbType { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 电话
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MB_MOBILE",false)]
        public string MbMobile { get; set; }
   
	}
}

