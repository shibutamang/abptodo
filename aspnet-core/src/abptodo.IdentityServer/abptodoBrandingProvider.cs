using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace abptodo
{
    [Dependency(ReplaceServices = true)]
    public class abptodoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "abptodo";
    }
}
