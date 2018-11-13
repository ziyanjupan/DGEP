using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QGEP.MultiTenancy.Dto;

namespace QGEP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
