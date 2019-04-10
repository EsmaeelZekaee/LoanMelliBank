using Abp.AutoMapper;
using LoanMelliBank.People.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMelliBank.Web.Models.People
{
    [AutoMapFrom(typeof(GetPersonForEditOutput))]
    public class EditPersonModalViewModel : GetPersonForEditOutput
    {
        public EditPersonModalViewModel(GetPersonForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}
