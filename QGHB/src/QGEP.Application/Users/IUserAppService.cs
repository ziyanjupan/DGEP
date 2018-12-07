using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QGEP.Roles.Dto;
using QGEP.Users.Dto;

namespace QGEP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}