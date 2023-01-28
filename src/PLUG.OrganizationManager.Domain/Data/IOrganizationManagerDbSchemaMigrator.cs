using System.Threading.Tasks;

namespace PLUG.OrganizationManager.Data;

public interface IOrganizationManagerDbSchemaMigrator
{
    Task MigrateAsync();
}
