using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：转发记录表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_game1_forward")]
	public class T_GAME1_FORWARD
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
        [Column("GA_CODE",false)]
        public string GaCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("GA_NAME",false)]
        public string GaName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("GROUP_ID",false)]
        public string GroupId { get; set; }
        /// <summary>
        /// 转发日期
        /// Type:date IsNull:YES Default:null
        /// </summary>
        [Column("FORWARD_DATE",false)]
        public DateTime? ForwardDate { get; set; }
        /// <summary>
        /// 群ID
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

