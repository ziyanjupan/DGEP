using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using QGEP.MultiTenancy;

namespace QGEP.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}