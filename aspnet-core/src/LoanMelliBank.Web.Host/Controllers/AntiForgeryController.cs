using Microsoft.AspNetCore.Antiforgery;
using LoanMelliBank.Controllers;

namespace LoanMelliBank.Web.Host.Controllers
{
    public class AntiForgeryController : LoanMelliBankControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
