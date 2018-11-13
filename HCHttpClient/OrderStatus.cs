namespace HCHttpClient
{
    [System.Flags]
    public enum OrderStatus
    {
        /// <summary>
        /// 默认状态，包含所有状态
        /// </summary>
        所有 = 0,

        /// <summary>
        /// 未提交，HR确认提交后才可以进行预约。
        /// </summary>
        待提交 = 1,

        ///// <summary>
        ///// 员工未绑定泛员之家员工公众号,绑定后才可以预约
        ///// </summary>
        //待绑定 = 2,

        /// <summary>
        /// 未预约 
        /// </summary>
        待预约 = 2,

        /// <summary>
        /// 预约但没有及时获取到预约结果的状态
        /// </summary>
        预约中 = 3,

        /// <summary>
        /// 预约失败 
        /// </summary>
        预约失败 = 4,

        /// <summary>
        /// 取消预约 
        /// </summary>
        取消预约 = 5,

        /// <summary>
        /// 未体检
        /// </summary>
        待体检 = 6,

        /// <summary>
        /// 预约当天状态
        /// </summary>
        体检中 = 7,

        /// <summary>
        /// 已去体检，报告生成中
        /// </summary>
        出报告中 = 8,

        /// <summary>
        /// 体检报告已出 
        /// </summary>
        报告已出 = 9,

        /// <summary>
        /// 没有体检报告且已超过体检合同有效期
        /// </summary>
        订单失效 = 10,

        /// <summary>
        /// 上一次绑定提醒三天后
        /// </summary>
        催绑定 = 11,

        /// <summary>
        /// 体检前一天
        /// </summary>
        体检前夜 = 12,

        /// <summary>
        /// 体检前晚
        /// </summary>
        TheNightOf = 13,

        /// <summary>
        /// 未登记
        /// </summary>
        Unchecked = 14,

        /// <summary>
        /// 用户绑定后三天未预约
        /// </summary>
        崔预约 = 15,
    }
}
