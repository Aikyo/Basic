using System.Collections.Generic;

namespace HCHttpClient
{
    public class FYProductDto
    {
        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 试用范围
        /// </summary>
        public string ApplyObject { get; set; }

        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal? SellPrice { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        ///// <summary>
        ///// 体检机构
        ///// </summary>
        //public IEnumerable<OrganizationDto> Organizations { get; set; }

        ///// <summary>
        ///// 体检详情
        ///// </summary>
        //public IEnumerable<ProductDetailDto> ExaminationDetail { get; set; }
    }
}
