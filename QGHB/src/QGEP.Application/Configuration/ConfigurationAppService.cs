using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QGEP.Configuration.Dto;

namespace QGEP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QGEPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
