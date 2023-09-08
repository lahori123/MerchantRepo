using MerchantPaymentServices.Models;
using MerchantPaymentServices.ServiceClient;

namespace MerchantPaymentServices.Manager
{
    public class DirectDebitManager
    {
        public DirectDebitManager() { }
        public CreateDDResp CreateDDManadate(CreateDDRequest req)
        {
            CreateDDResp resp = new CreateDDResp();
            resp = new DirectDebitClient().CreateDDManadate(req);
            return resp;
        }
        public GetDDMandateStatusResp GetDDMandateStatus(GetDDMandateStatusReq req)
        {
            GetDDMandateStatusResp resp = new GetDDMandateStatusResp();
            resp = new DirectDebitClient().GetDDMandateStatus(req);
            return resp;
        }
    }
}
