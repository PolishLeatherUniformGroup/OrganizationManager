using PLUG.OrganizationManager.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PLUG.OrganizationManager.Blazor;

public abstract class OrganizationManagerComponentBase : AbpComponentBase
{
    protected OrganizationManagerComponentBase()
    {
        LocalizationResource = typeof(OrganizationManagerResource);
    }
}
