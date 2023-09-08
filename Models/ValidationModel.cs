using FluentValidation;
using MerchantPaymentServices.Models;
using System;

namespace ElevyServiceClientCore.Models
{
    public class ValidationModel
    {
    }
    public class MMPaymentValidator : AbstractValidator<CreateMMPaymentReq>
    {
        public MMPaymentValidator() {
        
            RuleFor(x => x.mobile).NotEmpty();
            RuleFor(x => x.mobile_network).NotEmpty();
            RuleFor(x => x.currency).NotEmpty();
            RuleFor(x => x.amount).NotEmpty();
            RuleFor(x => x.order_id).NotEmpty();
            RuleFor(x => x.order_desc).NotEmpty();
            RuleFor(x => x.client_timestamp).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of clientTimestamp should be 'yyyy-MM-dd HH:mm:ss'.");
        }
        //public MMPaymentValidator()
        //{
        //    RuleFor(x => x.clientTransactionID).NotEmpty();
        //    RuleFor(x => x.clientTransactionID).Length(6, 36).WithMessage("clientTransactionID must be between 6 and 36 characters.");
        //    RuleFor(x => x.transferAmount).GreaterThan(0);
        //    RuleFor(x => x.clientTimestamp).NotEmpty();
        //    RuleFor(x => x.currency).NotEmpty();
        //    RuleFor(x => x.receiverAccountNumber).NotEmpty();
        //    RuleFor(x => x.receiverInstitutionID).NotEmpty();
        //    RuleFor(x => x.senderIssuerID).NotEmpty();
        //    RuleFor(x => x.senderAccountNumber).NotEmpty();
        //    RuleFor(x => x.senderAccountNumber).Length(4, 36).WithMessage("senderAccountNumber must be between 4 and 36 characters"); ;
        //    RuleFor(x => x.clientTimestamp).NotEmpty();
        //    RuleFor(x => x.clientTimestamp).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of clientTimestamp should be 'yyyy-MM-dd HH:mm:ss'.");
        //}
        //

    }
    public class InvoiceValidator : AbstractValidator<GetInvoiceStatusReq>
    {
        public InvoiceValidator()
        {

            RuleFor(x => x.order_id).NotEmpty();
        }
    }
    public class AccountProfileValidator : AbstractValidator<GetAccountProfileReq>
    {
        public AccountProfileValidator()
        {

            RuleFor(x => x.mobile).NotEmpty();
            RuleFor(x => x.network).NotEmpty();
        }
    }
    public class CustomerProfileValidator : AbstractValidator<GetCustomerProfileReq>
    {
        public CustomerProfileValidator()
        {
            RuleFor(x => x.app_id).NotEmpty();
            RuleFor(x => x.app_key).NotEmpty();
            RuleFor(x => x.mobile).NotEmpty();
            RuleFor(x => x.network).NotEmpty();
            RuleFor(x => x.countryCode).NotEmpty();
        }
    }
    public class CreateDDValidator : AbstractValidator<CreateDDRequest>
    {
        public CreateDDValidator()
        {
            RuleFor(x => x.app_id).NotEmpty();
            RuleFor(x => x.app_key).NotEmpty();
            RuleFor(x => x.client_code).NotEmpty();
            RuleFor(x => x.mobile_network).NotEmpty();
            RuleFor(x => x.payer_mobile).NotEmpty();
            RuleFor(x => x.payer_firstname).NotEmpty();
            RuleFor(x => x.payer_lastname).NotEmpty();
            RuleFor(x => x.dd_amount).NotEmpty();
            RuleFor(x => x.number_of_installments).NotEmpty();
            RuleFor(x => x.merch_trans_refno).NotEmpty();
            RuleFor(x => x.narration).NotEmpty();
            RuleFor(x => x.currency_code).NotEmpty();
            RuleFor(x => x.Installment_StartDate).NotEmpty();
            RuleFor(x => x.instrument_code).NotEmpty();
            RuleFor(x => x.frequency_period).NotEmpty();
            RuleFor(x => x.is_pre_auth_enable).NotEmpty();
            
        }
    }
    public class GetDDStatusValidator : AbstractValidator<GetDDMandateStatusReq>
    {
        public GetDDStatusValidator()
        {

            RuleFor(x => x.app_id).NotEmpty();
            RuleFor(x => x.app_key).NotEmpty();

            RuleFor(x => x.mobile_network).NotEmpty();
            RuleFor(x => x.mobile_number).NotEmpty();
        }
    }
    public class CreateCashoutValidator : AbstractValidator<CreateCashoutReq>
    {
        public CreateCashoutValidator()
        {
            RuleFor(x => x.app_id).NotEmpty();
            RuleFor(x => x.app_key).NotEmpty();
            RuleFor(x => x.transaction_date).NotEmpty();
            RuleFor(x => x.mobile_network).NotEmpty();
            RuleFor(x => x.payer_mobile).NotEmpty();
            RuleFor(x => x.expiry_date).NotEmpty();
            RuleFor(x => x.transaction_type).NotEmpty();
            RuleFor(x => x.payer_name).NotEmpty();
            RuleFor(x => x.currency).NotEmpty();
            RuleFor(x => x.amount).NotEmpty();
            RuleFor(x => x.merchant_ref).NotEmpty();
            RuleFor(x => x.payment_mode).NotEmpty();
            RuleFor(x => x.payee_name).NotEmpty();
            RuleFor(x => x.payee_mobile).NotEmpty();
        }
    }
    public class CashoutStatusValidator : AbstractValidator<CreateCashoutReq>
    {
        public CashoutStatusValidator()
        {
            RuleFor(x => x.app_id).NotEmpty();
            RuleFor(x => x.app_key).NotEmpty();
            RuleFor(x => x.merchant_ref).NotEmpty();
           
        }
    }


    //public class confirmReqValidator : AbstractValidator<ElevyconfirmReq>
    //{
    //    public confirmReqValidator()
    //    {
    //        RuleFor(x => x.clientTransactionID).NotEmpty();
    //        RuleFor(x => x.clientTransactionID).Length(6, 36).WithMessage("clientTransactionID must be between 6 and 36 characters.");
    //        RuleFor(x => x.transferAmount).GreaterThan(0);
    //        RuleFor(x => x.clientTimestamp).NotEmpty();
    //        RuleFor(x => x.currency).NotEmpty();
    //        RuleFor(x => x.receiverAccountNumber).NotEmpty();
    //        RuleFor(x => x.receiverInstitutionID).NotEmpty();
    //        RuleFor(x => x.senderIssuerID).NotEmpty();
    //        RuleFor(x => x.senderAccountNumber).NotEmpty();
    //        RuleFor(x => x.senderAccountNumber).Length(4, 36).WithMessage("senderAccountNumber must be between 4 and 36 characters"); ;
    //        RuleFor(x => x.clientTimestamp).NotEmpty();
    //        RuleFor(x => x.clientTimestamp).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of clientTimestamp should be 'yyyy-MM-dd HH:mm:ss'.");
    //        RuleFor(x => x.issuerDebitTransactionTimestamp).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of clientTimestamp should be 'yyyy-MM-dd HH:mm:ss'.");
    //        RuleFor(x => x.transferTransactionTimestamp).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of clientTimestamp should be 'yyyy-MM-dd HH:mm:ss'.");
    //    }
    //    //ElevyRefundExternal

    //}
    //public class ElevyRefundExternalValidator : AbstractValidator<ElevyRefundExternal>
    //{
    //    public ElevyRefundExternalValidator()
    //    {
    //        RuleFor(x => x.clientTransactionID).Must(x => string.IsNullOrEmpty(x) || x.Length >= 6 && x.Length <= 36)
    //                                           .WithMessage("The length of clientTransactionID must be between 6 and 36 characters.")
    //                                           .WithName("clientTransactionID");

    //        RuleFor(x => x.RefundAmount).GreaterThan(0);
    //    }
    //}
    //public class CLientTransactionIDValidator : AbstractValidator<string>
    //{
    //    public CLientTransactionIDValidator()
    //    {
    //        RuleFor(x => x)
    //                       .Must(x => string.IsNullOrEmpty(x) || x.Length >= 6 && x.Length <= 36)
    //                       .WithMessage("The length of the ClientTransactionID must be between 6 and 36 characters.");
    //    }
    //}
    //public class DateTimeValidator : AbstractValidator<string>
    //{
    //    public DateTimeValidator()
    //    {
    //        RuleFor(x => x).NotEmpty();
    //        RuleFor(x => x).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of clientTimestamp should be 'yyyy-MM-dd HH:mm:ss'.");
    //    }
    //}
    //public class DateRangeValidator : AbstractValidator<DateRange>
    //{
    //    public DateRangeValidator()
    //    {
    //        RuleFor(x => x.startdate).NotEmpty();
    //        RuleFor(x => x.startdate).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of startdate should be 'yyyy-MM-dd HH:mm:ss'.");
    //        RuleFor(x => x.enddate).NotEmpty();
    //        RuleFor(x => x.enddate).Matches(@"^\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}$").WithMessage("The format of enddate should be 'yyyy-MM-dd HH:mm:ss'.");
    //    }
    //}
    //public class DateRange {
    //    public string startdate { get; set; } = string.Empty;
    //    public string enddate { get; set; } = string.Empty;
    //}

}
