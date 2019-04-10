using Abp.Localization;
using LoanMelliBank.LoanInfo;
using LoanMelliBank.People.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanMelliBank.Web.Models.People
{
    public class PersonListViewModel
    {
        public IReadOnlyList<PersonListDto> People { get; set; }
        public PersonListViewModel()
        {
            PersonTypes = new List<SelectListItem>();
            PersonTypes.Add(new SelectListItem() { Text = L("NaturalPerson").ToString(), Value = PersonType.NaturalPerson.ToString() });
            PersonTypes.Add(new SelectListItem() { Text = L("LegalPerson").ToString(), Value = PersonType.LegalPerson.ToString() });
            AddressTypes = new List<SelectListItem>();
            AddressTypes.Add(new SelectListItem() { Text = L(AddressType.Home.ToString()).ToString(), Value = AddressType.Home.ToString() });
            AddressTypes.Add(new SelectListItem() { Text = L(AddressType.Office.ToString()).ToString(), Value = AddressType.Office.ToString() });
        }
        public IList<SelectListItem> PersonTypes { get; set; }
        public IList<SelectListItem> AddressTypes { get; set; }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LoanMelliBankConsts.LocalizationSourceName);
        }

    }
}
