using System.Threading.Tasks;
using Abp.Application.Services;
using LastProject.Sessions.Dto;

namespace LastProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
