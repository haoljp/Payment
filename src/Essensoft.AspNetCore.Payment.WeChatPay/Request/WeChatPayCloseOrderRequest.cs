using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    public class WeChatPayCloseOrderRequest : IWeChatPayRequest<WeChatPayCloseOrderResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/pay/closeorder";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "out_trade_no", OutTradeNo },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
            };
            return parameters;
        }

        #endregion
    }
}
