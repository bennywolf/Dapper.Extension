using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 滚动消息BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_scroll_message")]
	public class T_SCROLL_MESSAGE
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
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SM_CODE",false)]
        public string SmCode { get; set; }
        /// <summary>
        /// 分组
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SM_GROUP",false)]
        public int? SmGroup { get; set; }
        /// <summary>
        /// 是否圈子
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_CIRCLE",false)]
        public int? IsCircle { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SM_CONTENT",false)]
        public string SmContent { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

