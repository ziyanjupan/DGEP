﻿using System.Collections.Generic;
using QGEP.Roles.Dto;

namespace QGEP.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}