using Abp.Authorization;
using QGEP.Authorization.Roles;
using QGEP.Authorization.Users;

namespace QGEP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
