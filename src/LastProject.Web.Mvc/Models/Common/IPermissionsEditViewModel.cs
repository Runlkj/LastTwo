using System.Collections.Generic;
using LastProject.Roles.Dto;

namespace LastProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}