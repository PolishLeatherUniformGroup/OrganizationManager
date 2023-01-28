using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PLUG.OrganizationManager.Data;
using Volo.Abp.DependencyInjection;

namespace PLUG.OrganizationManager.EntityFrameworkCore;

public class EntityFrameworkCoreOrganizationManagerDbSchemaMigrator
    : IOrganizationManagerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOrganizationManagerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the OrganizationManagerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OrganizationManagerDbContext>()
            .Database
            .MigrateAsync();
    }
}
