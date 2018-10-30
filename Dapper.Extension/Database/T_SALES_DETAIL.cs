using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 销售明细BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_sales_detail")]
	public class T_SALES_DETAIL
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SD_CODE",false)]
        public string SdCode { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 用户姓名
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
        /// 获利金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 子用户
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SUB_CODE",false)]
        public string SubCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SUB_NAME",false)]
        public string SubName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SUB_HEAD_PHOTO",false)]
        public string SubHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("DESCRIPT",false)]
        public string Descript { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 级别
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SD_LEVEL",false)]
        public int? SdLevel { get; set; }
        /// <summary>
        /// 审核状态
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATUS",false)]
        public int? Status { get; set; }
        /// <summary>
        /// 订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SO_CODE",false)]
        public string SoCode { get; set; }
   
	}
}

