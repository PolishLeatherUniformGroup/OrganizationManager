using PLUG.OrganizationManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PLUG.OrganizationManager.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrganizationManagerEntityFrameworkCoreModule),
    typeof(OrganizationManagerApplicationContractsModule)
    )]
public class OrganizationManagerDbMigratorModule : AbpModule
{

}
