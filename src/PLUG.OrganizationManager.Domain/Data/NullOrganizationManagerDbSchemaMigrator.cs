using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PLUG.OrganizationManager.Data;

/* This is used if database provider does't define
 * IOrganizationManagerDbSchemaMigrator implementation.
 */
public class NullOrganizationManagerDbSchemaMigrator : IOrganizationManagerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
