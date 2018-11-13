using System.Collections.Generic;
using QGEP.Roles.Dto;
using QGEP.Users.Dto;

namespace QGEP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}