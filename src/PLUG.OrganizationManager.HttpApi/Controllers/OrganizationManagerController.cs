using PLUG.OrganizationManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PLUG.OrganizationManager.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OrganizationManagerController : AbpControllerBase
{
    protected OrganizationManagerController()
    {
        LocalizationResource = typeof(OrganizationManagerResource);
    }
}
