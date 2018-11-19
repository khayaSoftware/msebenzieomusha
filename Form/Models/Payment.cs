using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Form.Models
{
    public class Payment
    {
        public String HashDigest { get; set; }
        public String MerchantID { get; set; }
        public double Amount { get; set; }
        public String Currency { get; set; }
        public bool EchoAVSCheckResult { get; set; }
        public bool EchoCV2CheckResult { get; set; }
        public bool EchoThreeDSecureAuthenticationCheckResult { get; set; }
        public bool EchoCardType { get; set; }
        public String AVSOverridePolicy { get; set; }
        public String CV2Overridepolicy { get; set; }
        public String ThreeDSecureOverridePolicy { get; set; }
        public String OrderID { get; set; }
        public String TransactionType { get; set; }
        public String TransactionDateTime { get; set; }
        public String CallbackURL { get; set; }
        public bool EmailAddressEditable { get; set; }
        public bool PhoneNumberEditable { get; set; }
        public bool CV2Mandatory { get; set; }
        public bool Address1Mandatory { get; set; }
        public bool CityMandatory { get; set; }
        public bool PostCodeMandatory { get; set; }
        public bool StateMandatory { get; set; }
        public bool CountryMandatory { get; set; }
        public String ResultDeliveryMethod { get; set; }

        public static string Hash(string salt, string message)
        {
            var provider = MD5.Create();
            byte[] bytes = provider.ComputeHash(Encoding.ASCII.GetBytes(salt + message));
            return BitConverter.ToString(bytes);
        }
    }
}