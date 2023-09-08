using ElevyServiceClientCore.Models;
using MerchantPaymentServices.Manager;
using MerchantPaymentServices.Models;
using Microsoft.AspNetCore.Mvc;

namespace MerchantPaymentServices.Controllers
{
    public class DirectDebitController : Controller
    {
        [Route("createddmandate")]
        [HttpPost]
        public IActionResult CreateDDMandate(CreateDDRequest req)
        {
            CreateDDResp response = new CreateDDResp();
            // Fluent Valitdation
            var validator = new CreateDDValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new DirectDebitManager().CreateDDManadate(req);
                if (result != null)
                {
                    if (result.status_code == 1)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return Ok(result);
                    }
                }
                else
                {
                    response.status_message = "SERVICE ERROR ! Something went wrong";
                    return Ok(response);
                }
            }
            else
            {
                string errorMessage = string.Empty;
                foreach (var error in request.Errors)
                {
                    errorMessage += error.ErrorMessage;
                }
                response.status_message = "SERVICE ERROR ON VALIDATION :" + errorMessage;
                response.status_code = -1;
                return Ok(response);
            }

        }
        [Route("GetDDMandateStatus")]
        [HttpPost]
        public IActionResult GetDDMandateStatus(GetDDMandateStatusReq req)
        {
            GetDDMandateStatusResp response = new GetDDMandateStatusResp();
            // Fluent Valitdation
            var validator = new GetDDStatusValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new DirectDebitManager().GetDDMandateStatus(req);
                if (result != null)
                {
                    if (result.status_code == 1)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return Ok(result);
                    }
                }
                else
                {
                    response.status_message = "SERVICE ERROR ! Something went wrong";
                    return Ok(response);
                }
            }
            else
            {
                string errorMessage = string.Empty;
                foreach (var error in request.Errors)
                {
                    errorMessage += error.ErrorMessage;
                }
                response.status_message = "SERVICE ERROR ON VALIDATION :" + errorMessage;
                response.status_code = -1;
                return Ok(response);
            }

        }
    }
}
