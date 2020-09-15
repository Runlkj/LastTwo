using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LastProject.Controllers
{
    public abstract class LastProjectControllerBase: AbpController
    {
        protected LastProjectControllerBase()
        {
            LocalizationSourceName = LastProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
