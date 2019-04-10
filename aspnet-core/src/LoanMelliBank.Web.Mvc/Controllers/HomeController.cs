using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LoanMelliBank.Controllers;

namespace LoanMelliBank.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LoanMelliBankControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
