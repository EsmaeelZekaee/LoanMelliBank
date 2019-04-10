using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LoanMelliBank.Authorization;
using LoanMelliBank.Controllers;
using LoanMelliBank.People;
using LoanMelliBank.Web.Models.People;
using LoanMelliBank.People.Dto;

namespace LoanMelliBank.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_People)]
    public class PeopleController : LoanMelliBankControllerBase
    {
        private readonly IPeopleAppService _peopleAppService;

        public PeopleController(IPeopleAppService peopleAppService)
        {
            _peopleAppService = peopleAppService;
        }

        public async Task<IActionResult> Index(PagedPeopleResultRequestDto reques)
        {
            var people = (await _peopleAppService.GetPeopleAsync(new PagedPeopleResultRequestDto())).Items;
            var model = new PersonListViewModel()
            {
                People = people
            };
            return View(model);
        }

        public async Task<ActionResult> EditRoleModal(int personId)
        {
            var output = await _peopleAppService.GetPersonForEditAsync(personId);
            var model = new EditPersonModalViewModel(output);
            return View("_EditPeopleModal", model);
        }
    }
}
