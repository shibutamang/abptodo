using Volo.Abp.Modularity;

namespace abptodo
{
    [DependsOn(
        typeof(abptodoApplicationModule),
        typeof(abptodoDomainTestModule)
        )]
    public class abptodoApplicationTestModule : AbpModule
    {

    }
}