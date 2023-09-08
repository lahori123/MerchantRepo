using MerchantPaymentServices.Models;
using MerchantPaymentServices.ServiceClient;

namespace MerchantPaymentServices.Manager
{
    public class CashoutManager
    {
        public CashoutManager()
        {

        }
        public CreateCashoutResp CreateCashout(CreateCashoutReq req)
        {
            CreateCashoutResp resp = new CreateCashoutResp();
            resp = new CashoutClient().CreateCashout(req);
            return resp;
        }
        public CreateCashoutResp CheckStatus(CreateCashoutReq req)
        {
            CreateCashoutResp resp = new CreateCashoutResp();
            resp = new CashoutClient().CheckStatus(req);
            return resp;
        }
        
    }
}
