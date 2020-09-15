using Abp.AspNetCore.Mvc.ViewComponents;

namespace LastProject.Web.Views
{
    public abstract class LastProjectViewComponent : AbpViewComponent
    {
        protected LastProjectViewComponent()
        {
            LocalizationSourceName = LastProjectConsts.LocalizationSourceName;
        }
    }
}
