using System.Threading.Tasks;
using Abp.Application.Services;
using QGEP.Sessions.Dto;

namespace QGEP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
