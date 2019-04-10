using System.Collections.Generic;
using LoanMelliBank.Roles.Dto;

namespace LoanMelliBank.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
