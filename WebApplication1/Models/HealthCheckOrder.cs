using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class HealthCheckOrder
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 体检订单编号（e.g. 201808070001）
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 泛优订单ID
        /// </summary>
        public string FYUOrderId { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string PeopleId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string PeopleName { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 默认城市，预约地址需要在用户预约后才能获取
        /// </summary>
        public string DefaultCity { get; set; }

        /// <summary>
        /// 是否结婚（true:已结，false:未结）
        /// </summary>
        public bool IsMarried { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string ContactInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 体检订单创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 体检订单提交时间
        /// </summary>
        public DateTime SubmitTime { get; set; }

        /// <summary>
        /// 预约次数
        /// </summary>
        public int Amount { get; set; }
       
    }
}
