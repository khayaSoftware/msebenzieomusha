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
            PaymentForForm.HashDigest = Hash(PreSharedKey);

            return View(PaymentForForm);
            
        }
        public static string Hash(string stringToHash)
        {
            using (var sha1 = new SHA1Managed())
            {
                return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(stringToHash)));
            }
        }
    }
}