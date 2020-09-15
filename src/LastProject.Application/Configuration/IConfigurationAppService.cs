using System.Threading.Tasks;
using LastProject.Configuration.Dto;

namespace LastProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
