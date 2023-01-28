using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PLUG.OrganizationManager;

[Dependency(ReplaceServices = true)]
public class OrganizationManagerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OrganizationManager";
}
