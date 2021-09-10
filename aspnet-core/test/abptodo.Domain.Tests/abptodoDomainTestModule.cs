using abptodo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abptodo
{
    [DependsOn(
        typeof(abptodoEntityFrameworkCoreTestModule)
        )]
    public class abptodoDomainTestModule : AbpModule
    {

    }
}