using System.Security.Cryptography.X509Certificates;
namespace hampad.Areas.En.Controllers {
    using System.Threading.Tasks;
    using Dto.Payment;
    using Microsoft.AspNetCore.Mvc;
    using ZarinPal.Class;
[Area("en")]
    public class PayController : Controller {
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        public static string msg;
        
        

        public PayController () {
            var expose = new Expose ();
            _payment = expose.CreatePayment ();
            _authority = expose.CreateAuthority ();
            _transactions = expose.CreateTransactions ();
        }

        public IActionResult Index () {
            if (msg != null)
            {
                ViewBag.msg=msg;
                msg=null;
            }

            return View ();
        }
        //////////////////////////////////////////////////////////////////فرایند خرید
        public async Task<IActionResult> Request () {
            var result = await _payment.Request (new DtoRequest () {
                    Mobile = "09121112222",
                    CallbackUrl = "https://localhost:5001/pay/validate",
                    Description = "توضیحات",
                    Email = "farazmaan@outlook.com",
                    Amount = 1000000,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
            }, ZarinPal.Class.Payment.Mode.zarinpal);
            return Redirect ($"https://zarinpal.com/pg/StartPay/{result.Authority}");
        }
        ////////////////////////////////////////////////////////////////////اعتبار سنجی
        public async Task<IActionResult> Validate (string authority, string status) {
            var verification = await _payment.Verification (new DtoVerification {
                Amount = 1000000,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                    Authority = authority
            }, Payment.Mode.sandbox);


            if (verification.Status == 100)
            {
                msg="success";
                return RedirectToAction("index");
                
            }else
            {
                msg="error";
                return RedirectToAction("index");
            }
            
        }

    }
}