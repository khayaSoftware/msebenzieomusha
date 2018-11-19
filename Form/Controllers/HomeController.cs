using Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        private String PreSharedKey = "5XNm04UE0/EaXDSeKa4Fw29hTzieAl32uO4=";

        public ActionResult Index()
        {
            Payment PaymentForForm = new Payment();

            // Initialise Data (Ideally would be read from some sort of DB :/)
            PaymentForForm.HashDigest = Payment.Hash(PreSharedKey, "G6CH6Z90I2");
            PaymentForForm.MerchantID = "Progra-7702818";
            PaymentForForm.Amount = 20.00;
            PaymentForForm.EchoAVSCheckResult = true;
            PaymentForForm.EchoCV2CheckResult = true;
            PaymentForForm.EchoThreeDSecureAuthenticationCheckResult = true;
            PaymentForForm.EchoCardType = true;
            PaymentForForm.AVSOverridePolicy = "PPPP";
            PaymentForForm.CV2Overridepolicy = "PP";
            PaymentForForm.ThreeDSecureOverridePolicy = "true";
            PaymentForForm.OrderID = "Order-1234";
            PaymentForForm.TransactionType = "SALE";
            PaymentForForm.TransactionDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss K");
            PaymentForForm.CallbackURL = "http://localhost:51772/Home/Index";
            PaymentForForm.EmailAddressEditable = true;
            PaymentForForm.PhoneNumberEditable = true;
            PaymentForForm.CV2Mandatory = true;
            PaymentForForm.PostCodeMandatory = true;
            PaymentForForm.StateMandatory = true;
            PaymentForForm.CountryMandatory = true;
            PaymentForForm.ResultDeliveryMethod = "POST";

            return View(PaymentForForm);
            
        }
        
    }
}