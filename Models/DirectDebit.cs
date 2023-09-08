using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MerchantPaymentServices.Models
{
    public class CreateDDRequest:Baserequest
    {
        [DefaultValue("CC989765")]
        public string client_code { get; set; }
        [DefaultValue("MTN")]
        public string mobile_network { get; set; }
        [DefaultValue("+233555515326")]
        public string payer_mobile { get; set; }
        [DefaultValue("Peter")]
        public string payer_firstname { get; set; }
        [DefaultValue("Adua")]
        public string payer_lastname { get; set; }
        [DefaultValue("1.10")]
        public string dd_amount { get; set; }
        [DefaultValue("5")]
        public string number_of_installments { get; set; }
        [Required(ErrorMessage = "Merchant Ref should be unique.")]
        public string merch_trans_refno { get; set; }
        [DefaultValue("Installment")]
        public string narration { get; set; }
        [DefaultValue("GHS")]
        public string currency_code { get; set; }
        [DefaultValue("2023-06-28 10:06:08")]
        public string Installment_StartDate { get; set; }
        [DefaultValue("DAILY")]
        public string Frequency_Code { get; set; }  
        public string instrument_code { get; set; }
        [DefaultValue("5")]
        public int frequency_period { get; set; }
        [DefaultValue("0")]
        public int is_pre_auth_enable { get; set; }

    }
    public class CreateDDResp
    {
        public int status_code { get; set; }
        public string status_message { get; set; }
        public Int64 tran_ref_no { get; set; }

    }
    public class GetDDMandateStatusReq:Baserequest
    {
        //Test comment
        [DefaultValue("+233555515326")]
        public string mobile_number { get; set; }
        [DefaultValue("MTN")]
        public string mobile_network { get; set; }

    }
    public class GetDDMandateStatusResp:Baseresponse
    {
        public string ddStatus { get; set; }

    }
}
