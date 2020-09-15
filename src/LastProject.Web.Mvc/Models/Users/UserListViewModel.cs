using System.Collections.Generic;
using LastProject.Roles.Dto;

namespace LastProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
