using System.Collections.Generic;
using LoanMelliBank.Roles.Dto;

namespace LoanMelliBank.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}