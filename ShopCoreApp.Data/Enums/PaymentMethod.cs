using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShopCoreApp.Data.Enums
{
    public enum PaymentMethod
    {
        [Description("Thanh toán khi giao hàng")]
        CashOnDelivery,
        [Description("Ngân hàng trực tuyến")]
        OnlinBanking,
        [Description("Cổng thanh toán")]
        PaymentGateway,
        [Description("Visa")]
        Visa,
        [Description("Thẻ Master")]
        MasterCard,
        [Description("PayPal")]
        PayPal,
        [Description("Atm")]
        Atm
    }
}
