using System.Collections.Generic;
using LoanMelliBank.Roles.Dto;
using LoanMelliBank.Users.Dto;

namespace LoanMelliBank.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
