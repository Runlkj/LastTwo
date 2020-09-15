using Abp.Application.Services;
using LastProject.MultiTenancy.Dto;

namespace LastProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

