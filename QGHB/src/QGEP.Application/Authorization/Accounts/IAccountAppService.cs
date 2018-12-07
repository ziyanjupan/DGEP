using System.Threading.Tasks;
using Abp.Application.Services;
using QGEP.Authorization.Accounts.Dto;

namespace QGEP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
