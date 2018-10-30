using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户消息BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member_message")]
	public class T_MEMBER_MESSAGE
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 0九仙号外,1系统消息,2交易消息,3客服消息
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MM_GROUP",false)]
        public int? MmGroup { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MM_CODE",false)]
        public string MmCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("CONTENT",false)]
        public string Content { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PAGE",false)]
        public string Page { get; set; }
        /// <summary>
        /// 是否已读
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_READ",false)]
        public int? IsRead { get; set; }
   
	}
}

