using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 游戏1：参与记录BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_game1_drawn_member")]
	public class T_GAME1_DRAWN_MEMBER
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
        [Column("GD_CODE",false)]
        public string GdCode { get; set; }
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
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 期数
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("GA_CODE",false)]
        public string GaCode { get; set; }
        /// <summary>
        /// 期数
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("GA_NAME",false)]
        public string GaName { get; set; }
        /// <summary>
        /// 奖品
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("GP_CODE",false)]
        public string GpCode { get; set; }
        /// <summary>
        /// 奖品
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("GP_TYPE",false)]
        public int? GpType { get; set; }
        /// <summary>
        /// 奖品名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("GP_NAME",false)]
        public string GpName { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(10,0) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CO_CODE",false)]
        public string CoCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("IMAGE",false)]
        public string Image { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

