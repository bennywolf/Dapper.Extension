using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：大转盘期数BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_game1")]
	public class T_GAME1
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
        /// 奖品名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("GA_NAME",false)]
        public string GaName { get; set; }
        /// <summary>
        /// 规则
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("GA_RULE",false)]
        public string GaRule { get; set; }
        /// <summary>
        /// 说明
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("GA_DESC",false)]
        public string GaDesc { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_ON",false)]
        public int? IsOn { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

