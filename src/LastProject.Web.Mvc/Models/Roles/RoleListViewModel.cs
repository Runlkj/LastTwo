using System.Collections.Generic;
using LastProject.Roles.Dto;

namespace LastProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
