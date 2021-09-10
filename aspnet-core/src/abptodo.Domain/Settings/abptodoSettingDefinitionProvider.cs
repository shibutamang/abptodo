using Volo.Abp.Settings;

namespace abptodo.Settings
{
    public class abptodoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(abptodoSettings.MySetting1));
        }
    }
}
