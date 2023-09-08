namespace MerchantPaymentServices.Models
{
    public class PaymentClientConfig
    {
        public static string createMMPaymentURL { get; set; } = string.Empty;
        public static string GetInvoiceURL { get; set; } = string.Empty;
        public static string GetAccountProfileURL { get; set; } = string.Empty;
        public static string GetCustomerProfileURL { get; set; } = string.Empty;
        public static string CreateDDMandateURL { get; set; } = string.Empty;
        public static string GetDDMandateStatus { get; set; } = string.Empty;
        



    }
    public class CashoutConfig
    {
        public static string CreateCashoutURL { get; set; } = string.Empty;
        public static string CheckStatusURL { get; set; } = string.Empty;
        
    }
}
