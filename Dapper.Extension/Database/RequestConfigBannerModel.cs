using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// bannerBASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestConfigBannerModel : RequstModel
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// code
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CbCode { get; set; }
        /// <summary>
        /// 图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Img { get; set; }
        /// <summary>
        /// url
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 是否上线
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsOnline { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        public int? CreateTimestemp { get; set; }
        /// <summary>
        /// 0首页顶部banner,1社区bannner,2首页广告banner
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? CbGroup { get; set; }
        /// <summary>
        /// 排序
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Sort { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_CONFIG_BANNER GetEntity()
		{
			return new T_CONFIG_BANNER()
			{
				Id = this.Id,
				CbCode = this.CbCode,
				Img = this.Img,
				Url = this.Url,
				IsOnline = this.IsOnline,
				CreateTime = this.CreateTime,
				CreateTimestemp = this.CreateTimestemp,
				CbGroup = this.CbGroup,
				Sort = this.Sort,
 
			};
		}
	}
}

