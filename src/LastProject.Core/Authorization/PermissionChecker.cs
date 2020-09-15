using Abp.Authorization;
using LastProject.Authorization.Roles;
using LastProject.Authorization.Users;

namespace LastProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
