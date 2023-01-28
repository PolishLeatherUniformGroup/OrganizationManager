using PLUG.OrganizationManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PLUG.OrganizationManager.Permissions;

public class OrganizationManagerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OrganizationManagerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OrganizationManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrganizationManagerResource>(name);
    }
}
