﻿using MerchantPaymentServices.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;


namespace MerchantPaymentServices.ServiceClient

{
    public class InterapiClient
    {
        public InterapiClient()
        {

        }

        public CreateCreateMMPaymentReqResp CreateMMPayment(CreateMMPaymentReq req)
        {
            string result = string.Empty;
            CreateCreateMMPaymentReqResp response = new CreateCreateMMPaymentReqResp();
            try
            {
                result = HttpPost(JsonConvert.SerializeObject(req), PaymentClientConfig.createMMPaymentURL, "CreateMMPayment"); //HttpPost(JsonConvert.SerializeObject(req), ElevyConfigs.reserveURL);
                response = JsonConvert.DeserializeObject<CreateCreateMMPaymentReqResp>(result);
            }
            catch (Exception ex)
            {
                response.statusMessage = $"MicroService error on parsing: {ex.Message} and Response From elevy: {result}";
                response.statusCode = -1;
            }
            return response;
        }
        public GetInvoiceStatusResp GetInvoiceStatus(GetInvoiceStatusReq req)
        {
            string result = string.Empty;
            GetInvoiceStatusResp response = new GetInvoiceStatusResp();
            try
            {
                result = HttpPost(JsonConvert.SerializeObject(req), PaymentClientConfig.GetInvoiceURL, "GetInvoiceStatus"); //HttpPost(JsonConvert.SerializeObject(req), ElevyConfigs.reserveURL);
                response = JsonConvert.DeserializeObject<GetInvoiceStatusResp>(result);
            }
            catch (Exception ex)
            {
                response.status_message = $"MicroService error on parsing: {ex.Message} and Response From elevy: {result}";
                response.status_code = -1;
            }
            return response;
        }
        public GetAccountProfileResp GetAccountProfile(GetAccountProfileReq req)
        {
            string result = string.Empty;
            GetAccountProfileResp response = new GetAccountProfileResp();
            try
            {
                result = HttpPost(JsonConvert.SerializeObject(req), PaymentClientConfig.GetAccountProfileURL, "GetAccountProfile"); //HttpPost(JsonConvert.SerializeObject(req), ElevyConfigs.reserveURL);
                response = JsonConvert.DeserializeObject<GetAccountProfileResp>(result);
            }
            catch (Exception ex)
            {
                response.status_message = $"MicroService error on parsing: {ex.Message} and Response From elevy: {result}";
                response.status_code = "1";
            }
            return response;
        }
        public GetCustomerProfileResp GetCustomerProfile(GetCustomerProfileReq req)
        {
            string result = string.Empty;
            GetCustomerProfileResp response = new GetCustomerProfileResp();
            try
            {
                result = HttpPost(JsonConvert.SerializeObject(req), PaymentClientConfig.GetAccountProfileURL, "GetCustomerProfile"); //HttpPost(JsonConvert.SerializeObject(req), ElevyConfigs.reserveURL);
                response = JsonConvert.DeserializeObject<GetCustomerProfileResp>(result);
            }
            catch (Exception ex)
            {
                response.status_message = $"MicroService error on parsing: {ex.Message} and Response From elevy: {result}";
                response.status_code = "1";
            }
            return response;
        }

        private static string HttpPost(string data, string Url, [CallerMemberName] string FuncName = "", string transid = "0")
        {
           // Stopwatch stopwatch = new Stopwatch();
            string response = "";
            Stream myWriter = null;
            string headers = string.Empty;
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                       | SecurityProtocolType.Tls11
                       | SecurityProtocolType.Tls12;

                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(Url);
               // objRequest.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateServerCertificate);
                objRequest.Proxy = null;
                objRequest.UseDefaultCredentials = true;
                objRequest.Method = "POST";
                objRequest.ContentLength = byteArray.Length;
                objRequest.ContentType = "application/json";
                objRequest.Accept = "application/json";
               // objRequest.Headers.Add("X-API-KEY", ElevyConfigs.X_API_KEY);
          
                // original logic that was there 
              //  var cert = CertificateConfigs.Certificate;
               // objRequest.ClientCertificates.Add(cert);
                headers = objRequest.Headers.ToString();
                //Logging.GenericloggingwithHeaders(FuncName, "Info", "URL" + Url + " Request Parsed: " + data + "Headers:" + headers);
                //stopwatch.Start();
                using (myWriter = objRequest.GetRequestStream())
                {
                    myWriter.Write(byteArray, 0, byteArray.Length);
                }
                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr =
                new StreamReader(objResponse.GetResponseStream()))
                {
                    response = sr.ReadToEnd();
                    sr.Close();
                }
                //stopwatch.Stop();
                //Logging.GenericloggingwithHeaders(FuncName, "Info", "URL" + Url + " Response: " + JsonConvert.SerializeObject(response) + " Time Taken: " + stopwatch.Elapsed.TotalMilliseconds);
            }
            catch (WebException e)
            {
                //stopwatch.Stop();
                var resp = new StreamReader(e.Response.GetResponseStream()).ReadToEnd();
                response += resp;

                //Logging.GenericloggingwithHeaders(FuncName, "Exception", "API Name: " + ApiName + "Function Name: " + FuncName + "URL Called: " + Url + "Excemption: " + e + " Error Response " + response + "Request API: " + data + "Trans Id: " + transid + "Time Taken: " + stopwatch.Elapsed.TotalMilliseconds + "Headers:" + headers);
                return response;
            }
            finally
            {
                if (myWriter != null)
                    myWriter.Close();
            }
            return response;
        }
        //private static string HttpGet(string data, string Url, [CallerMemberName] string FuncName = "", string transid = "0")
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    string response = "";
        //    Stream myWriter = null;
        //    string headers = string.Empty;
        //    try
        //    {
        //        ServicePointManager.Expect100Continue = true;
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
        //           | SecurityProtocolType.Tls11
        //           | SecurityProtocolType.Tls12;


        //        byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
        //        HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(Url);
        //        objRequest.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateServerCertificate);

        //        objRequest.Proxy = null;
        //        objRequest.UseDefaultCredentials = true;
        //        objRequest.Method = "GET";
        //        objRequest.ContentType = "application/json";
        //        objRequest.Accept = "application/json";
        //        objRequest.Headers.Add("X-API-KEY", ElevyConfigs.X_API_KEY);

        //        // original logic that was there 
        //        var cert = CertificateConfigs.Certificate;
        //        objRequest.ClientCertificates.Add(cert);
        //        headers = objRequest.Headers.ToString();
        //        objRequest.Timeout = ElevyConfigs.CircuitBreakerInMiliSeconds;
        //        Logging.GenericloggingwithHeaders(FuncName, "Info", "URL" + Url + " Request Parsed: " + data + "Headers:" + headers);

        //        stopwatch.Start();
        //        HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
        //        using (StreamReader sr =
        //        new StreamReader(objResponse.GetResponseStream()))
        //        {
        //            response = sr.ReadToEnd();
        //            sr.Close();
        //        }
        //        stopwatch.Stop();
        //        Logging.GenericloggingwithHeaders(FuncName, "Info", "URL" + Url + " Response: " + JsonConvert.SerializeObject(response) + " Time Taken: " + stopwatch.Elapsed.TotalMilliseconds);
        //    }
        //    catch (WebException e)
        //    {
        //        if (e.Response != null)
        //        {
        //            stopwatch.Stop();
        //            var resp = new StreamReader(e.Response.GetResponseStream()).ReadToEnd();
        //            response += resp;
        //        }
        //        Logging.GenericloggingwithHeaders(FuncName, "Exception", "API Name: " + ApiName + "Function Name: " + FuncName + "URL Called: " + Url + "Excemption: " + e + " Error Response " + response + "Request API: " + data + "Trans Id: " + transid + "Time Taken: " + stopwatch.Elapsed.TotalMilliseconds + "Headers:" + headers);
        //    }
        //    finally
        //    {
        //        if (myWriter != null)
        //            myWriter.Close();
        //    }
        //    return response;
        //}

    }
}
