namespace MerchantPaymentServices.Models
{
    public class GetCustomerProfileReq
    {
        
            public string app_id { get; set; }
            public string app_key { get; set; }
            public string mobile { get; set; }
            public string network { get; set; }
            public string countryCode { get; set; }
        
    }
    
     public class GetCustomerProfileResp
     {
        public string status_code { get; set; }
        public string status_message { get; set; }
        public bool Isvalid { get; set; }
        public object surname { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string country { get; set; }
    }


}
