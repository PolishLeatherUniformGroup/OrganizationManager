using PLUG.OrganizationManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PLUG.OrganizationManager;

[DependsOn(
    typeof(OrganizationManagerEntityFrameworkCoreTestModule)
    )]
public class OrganizationManagerDomainTestModule : AbpModule
{

}
