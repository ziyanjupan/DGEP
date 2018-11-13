using System.Threading.Tasks;
using Abp.Application.Services;
using QGEP.Configuration.Dto;

namespace QGEP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}