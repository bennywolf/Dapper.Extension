using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 圈子BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_circle")]
	public class T_CIRCLE
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
        [Column("CI_CODE",false)]
        public string CiCode { get; set; }
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
        /// 标题
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("TITLE",false)]
        public string Title { get; set; }
        /// <summary>
        /// 缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("THUMBNAIL",false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// 正文
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("CONTENT",false)]
        public string Content { get; set; }
        /// <summary>
        /// 图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("IMAGES",false)]
        public string Images { get; set; }
        /// <summary>
        /// 浏览量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("BRO_COUNT",false)]
        public int? BroCount { get; set; }
        /// <summary>
        /// 点赞量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("LIK_COUNT",false)]
        public int? LikCount { get; set; }
        /// <summary>
        /// 评论次数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("COM_COUNT",false)]
        public int? ComCount { get; set; }
        /// <summary>
        /// 宝贝,产品
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("PR_CODE_LIST",false)]
        public string PrCodeList { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("LOCATION",false)]
        public string Location { get; set; }
   
	}
}

