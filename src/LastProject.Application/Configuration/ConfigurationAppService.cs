using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LastProject.Configuration.Dto;

namespace LastProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LastProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
