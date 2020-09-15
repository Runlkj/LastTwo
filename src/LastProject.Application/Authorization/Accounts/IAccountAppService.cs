using System.Threading.Tasks;
using Abp.Application.Services;
using LastProject.Authorization.Accounts.Dto;

namespace LastProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
