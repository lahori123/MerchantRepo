using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MerchantPaymentServices.Models
{
    public class CreateCashoutReq:Baserequest
    {
            [DefaultValue("2023-06-28 10:06:08")]
            public string transaction_date { get; set; }
            [DefaultValue("2023-10-14 10:06:08")]
            public string expiry_date { get; set; }
            [DefaultValue("local")]
            public string transaction_type { get; set; }
            [DefaultValue("MMT")]
            public string payment_mode { get; set; }
            [DefaultValue("Peter Adua")]
            public string payer_name { get; set; }
            [DefaultValue("PeterAdua@gmail.com")]
            public string payer_email { get; set; }
            [DefaultValue("GHS")]
            public string currency { get; set; }
            [DefaultValue("3.5")]
            public string amount { get; set; }
            [Required(ErrorMessage = "Merchant Ref should be unique.")]
            public string merchant_ref { get; set; }
            [DefaultValue("+233264391256")]
            public string payer_mobile { get; set; }
            [DefaultValue("+233264371234")]
            public string payee_mobile { get; set; }
            [DefaultValue("AIRTELTIGO")]
            public string mobile_network { get; set; }
            [DefaultValue("Charles")]
            public string payee_name { get; set; }
    }
    public class CreateCashoutResp
    {
        public string status_code { get; set; }
        public string status_message { get; set; }
        public int transaction_ref { get; set; }
    }   
}