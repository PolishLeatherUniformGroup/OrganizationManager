using System;
using System.Collections.Generic;
using System.Text;
using PLUG.OrganizationManager.Localization;
using Volo.Abp.Application.Services;

namespace PLUG.OrganizationManager;

/* Inherit your application services from this class.
 */
public abstract class OrganizationManagerAppService : ApplicationService
{
    protected OrganizationManagerAppService()
    {
        LocalizationResource = typeof(OrganizationManagerResource);
    }
}
