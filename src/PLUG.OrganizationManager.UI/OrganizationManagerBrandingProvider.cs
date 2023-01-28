using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PLUG.OrganizationManager.Blazor;

[Dependency(ReplaceServices = true)]
public class OrganizationManagerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OrganizationManager";
}
