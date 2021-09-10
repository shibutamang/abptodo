using abptodo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abptodo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(abptodoEntityFrameworkCoreModule),
        typeof(abptodoApplicationContractsModule)
        )]
    public class abptodoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
