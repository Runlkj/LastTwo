using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using LastProject.Authorization;

namespace LastProject.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class LastProjectNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem( //一级菜单 - 首页
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Home)
                    )
                )
                    .AddItem( //一级菜单 - 收费
                        new MenuItemDefinition(
                            PageNames.GetMoney,
                            L("GetMoney"),
                            url: "GetMoney",
                            permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_GetMoney)
                        )
                    )
                .AddItem( //一级菜单 - 系统设置
                    new MenuItemDefinition(
                        "Setting",
                        L("Setting"),
                        icon: "settings"
                    )
                )
                .AddItem( //二级菜单 - 租户管理
                        new MenuItemDefinition(
                            PageNames.Tenants,
                            L("Tenants"),
                            url: "Tenants",
                            permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenants)
                        )
                    ).AddItem( //二级菜单 - 用户管理
                        new MenuItemDefinition(
                            PageNames.Users,
                            L("Users"),
                            url: "Users",
                            permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
                        )
                    ).AddItem( //一级菜单 - 角色管理
                        new MenuItemDefinition(
                            PageNames.Roles,
                            L("Roles"),
                            url: "Roles",
                            permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
                        )
                    )
                .AddItem( //一级菜单 - 关于
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info",
                        requiresAuthentication: true
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LastProjectConsts.LocalizationSourceName);
        }
    }
}
