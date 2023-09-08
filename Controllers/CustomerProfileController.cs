using ElevyServiceClientCore.Models;
using MerchantPaymentServices.Manager;
using MerchantPaymentServices.Models;
using Microsoft.AspNetCore.Mvc;

namespace MerchantPaymentServices.Controllers
{
    public class CustomerProfileController : Controller
    {
        
        public IActionResult GetCustomerProfile(GetCustomerProfileReq req)
        {
            GetCustomerProfileResp response = new GetCustomerProfileResp();
            // Fluent Valitdation
            var validator = new CustomerProfileValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new InterapiManager().GetCustomerProfile(req);
                if (result != null)
                {
                    if (result.status_code == "1")
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
                response.status_code = "-1";
                return Ok(response);
            }

        }
    }
}
