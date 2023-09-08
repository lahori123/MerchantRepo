using ElevyServiceClientCore.Models;
using MerchantPaymentServices.Manager;
using MerchantPaymentServices.Models;
using Microsoft.AspNetCore.Mvc;

namespace MerchantPaymentServices.Controllers
{
    public class CashoutController : Controller
    {

        [Route("CreateCashout")]
        [HttpPost]
        public IActionResult CreateCashout(CreateCashoutReq req)
        {
            CreateCashoutResp response = new CreateCashoutResp();
            // Fluent Valitdation
            var validator = new CreateCashoutValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new CashoutManager().CreateCashout(req);
                if (result != null)
                {
                    if (result.status_code == "")
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

        [Route("CheckStatus ")]
        [HttpPost]
        public IActionResult CheckStatus(CreateCashoutReq req)
        {
            CreateCashoutResp response = new CreateCashoutResp();
            // Fluent Valitdation
            var validator = new CashoutStatusValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new CashoutManager().CheckStatus(req);
                if (result != null)
                {
                    if (result.status_code == "")
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


        [Route("GetAccountProfile")]
        [HttpPost]
        public IActionResult GetAccountProfile(GetAccountProfileReq req)
        {
            GetAccountProfileResp response = new GetAccountProfileResp();
            // Fluent Valitdation
            var validator = new AccountProfileValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new InterapiManager().GetAccountProfile(req);
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
