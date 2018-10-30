using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// VIEWVIEW
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("v_organization")]
	public class V_ORGANIZATION
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        [Column("ID",false)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("OG_NAME",false)]
        public string OgName { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("LEFT_NUM",false)]
        public int? LeftNum { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("RIGHT_NUM",false)]
        public int? RightNum { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("ORGANIZATION_LAYER",false)]
        public int? OrganizationLayer { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("OG_CODE",false)]
        public string OgCode { get; set; }
   
	}
}

