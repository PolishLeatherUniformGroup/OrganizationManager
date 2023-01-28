using Volo.Abp.Modularity;

namespace PLUG.OrganizationManager;

[DependsOn(
    typeof(OrganizationManagerApplicationModule),
    typeof(OrganizationManagerDomainTestModule)
    )]
public class OrganizationManagerApplicationTestModule : AbpModule
{

}
