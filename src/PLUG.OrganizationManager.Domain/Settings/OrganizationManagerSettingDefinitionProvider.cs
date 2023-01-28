using Volo.Abp.Settings;

namespace PLUG.OrganizationManager.Settings;

public class OrganizationManagerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OrganizationManagerSettings.MySetting1));
    }
}
