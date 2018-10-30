using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 圈子评论BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_circle_comment")]
	public class T_CIRCLE_COMMENT
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 圈子
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CI_CODE",false)]
        public string CiCode { get; set; }
        /// <summary>
        /// 圈子评论
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CC_CODE",false)]
        public string CcCode { get; set; }
        /// <summary>
        /// 评论的父评论CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PCC_CODE",false)]
        public string PccCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PME_NAME",false)]
        public string PmeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PME_HEAD_PHOTO",false)]
        public string PmeHeadPhoto { get; set; }
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
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 正文
        /// Type:text IsNull:YES Default:null
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
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIMESTAMP",false)]
        public string CreateTimestamp { get; set; }
   
	}
}

