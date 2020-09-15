﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LastProject.Web.Views
{
    public abstract class LastProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LastProjectRazorPage()
        {
            LocalizationSourceName = LastProjectConsts.LocalizationSourceName;
        }
    }
}
