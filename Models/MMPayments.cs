using System.ComponentModel;
using System.Text;

namespace MerchantPaymentServices.Models
{
    public abstract class Baserequest
    {
        [DefaultValue("9057423960")]
        public string app_id { get; set; }
        [DefaultValue("46540203")]
        public string app_key { get; set; }
    }
    public abstract class Baseresponse
    {
        public int status_code { get; set; }
        public string status_message { get; set; }
    }

    public class CreateMMPaymentReq: Baserequest
    {
        [DefaultValue("9057423960")]
        public string app_id { get; set; }
        [DefaultValue("46540203")]
        public string app_key { get; set; }
        [DefaultValue("Peter Adua")]
        public string name { get; set; }
        [DefaultValue("PeterAdua@gmail.com")]  
        public string email { get; set; }
        [DefaultValue("+233501149440")]
        public string mobile { get; set; }
        [DefaultValue("MTN")]
        public string mobile_network { get; set; }
        [DefaultValue("GHS")]
        public string currency { get; set; }
        [DefaultValue("9904491")]
        public string order_id { get; set; }
        [DefaultValue("12.10")]  
        public double amount { get; set; }
        public double voucher_code { get; set; }
        [DefaultValue("Peter Adua Order")]
        public string order_desc { get; set; }
        [DefaultValue("GENERALPAYMENT")]  
        public string feetypecode { get; set; }
             
        public string signature { get; set; }
          
        public string signature_method { get; set; }
          
        public string return_url { get; set; }
          
        public string client_timestamp { get; set; }
          
        public string terminal_id { get; set; }
          
        public string merchantcode { get; set; }
          

    }
    public class CreateCreateMMPaymentReqResp
    {
        public int statusCode { get; set; } 
        public string statusMessage { get; set; } = string.Empty;
        public string transaction_no { get; set; } = string.Empty;
        public string merchantcode { get; set; }

        public string serverTimestamp { get; set; } = string.Empty;
        public string error { get; set; } = string.Empty;
    }
    public class GetInvoiceStatusReq: Baserequest
    {
        public string order_id { get; set; }
    }
    public class GetInvoiceStatusResp
    {

        public int status_code { get; set; }
        public string status_message { get; set; }
        public int SYSTEM_TRANS_ID { get; set; }
        public string TELCO_TRANSACTION_DATE { get; set; }
        public string TELCO_TRANSACTION_ID { get; set; }
        public string account_no { get; set; }
        public double amount { get; set; }
        public string order_id { get; set; }
        public string payment_mode { get; set; }
        public string reason { get; set; }
        public string status_desc { get; set; }
        public string trans_ref_no { get; set; }
    }

    public class GetAccountProfileReq: Baserequest
    {
        [DefaultValue("+233555515326")]
        public string mobile { get; set; }
        [DefaultValue("MTN")]
        public string network { get; set; }
    }
    public class GetAccountProfileResp
    {
        public string status_code { get; set; }
        public string status_message { get; set; }
        public bool Isvalid { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
    }
}
