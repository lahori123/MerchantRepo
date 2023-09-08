using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MerchantPaymentServices.Models;
using ElevyServiceClientCore.Models;
using MerchantPaymentServices.Manager;

namespace MerchantPaymentServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterapiController : ControllerBase
    {

        [Route("CreateMMPayment")]
        [HttpPost]
        public IActionResult CreateMMPayment(CreateMMPaymentReq req)
        {
            CreateCreateMMPaymentReqResp response = new CreateCreateMMPaymentReqResp();
            // Fluent Valitdation
            var validator = new MMPaymentValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new InterapiManager().CreateMMPayment(req);
                if (result != null)
                {
                    if (result.statusCode == 1)
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
                    response.statusMessage = "SERVICE ERROR ! Something went wrong";
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
                response.statusMessage = "SERVICE ERROR ON VALIDATION :" + errorMessage;
                response.statusCode = -1;
                return Ok(response);
            }

        }

        [Route("GetInvoiceStatus")]
        [HttpPost]
        public IActionResult GetInvoiceStatus(GetInvoiceStatusReq req)
        {
            GetInvoiceStatusResp response = new GetInvoiceStatusResp();
            // Fluent Valitdation
            var validator = new InvoiceValidator();
            var request = validator.Validate(req);

            if (request.IsValid)
            {
                var result = new InterapiManager().GetInvoiceStatus(req);
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
