using Abp.Authorization;
using LoanMelliBank.Authorization.Roles;
using LoanMelliBank.Authorization.Users;

namespace LoanMelliBank.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
