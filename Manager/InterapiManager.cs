using MerchantPaymentServices.DAL;
using MerchantPaymentServices.Models;
using MerchantPaymentServices.ServiceClient;

namespace MerchantPaymentServices.Manager
{
    public class InterapiManager
    {
        public InterapiManager()
        {

        }
        public CreateCreateMMPaymentReqResp CreateMMPayment(CreateMMPaymentReq req)
        {
            CreateCreateMMPaymentReqResp resp = new CreateCreateMMPaymentReqResp();
            resp = new InterapiClient().CreateMMPayment(req);
            return resp;
        }
        public GetInvoiceStatusResp GetInvoiceStatus(GetInvoiceStatusReq req)
        {
            GetInvoiceStatusResp resp = new GetInvoiceStatusResp();
            resp = new InterapiClient().GetInvoiceStatus(req);
            return resp;
        }
        public GetAccountProfileResp GetAccountProfile(GetAccountProfileReq req)
        {
            GetAccountProfileResp resp = new GetAccountProfileResp();
            resp = new InterapiClient().GetAccountProfile(req);
            return resp;
        }
        public GetCustomerProfileResp GetCustomerProfile(GetCustomerProfileReq req)
        {
            GetCustomerProfileResp resp = new GetCustomerProfileResp();
            resp = new InterapiClient().GetCustomerProfile(req);
            return resp;
        }
    }
}
