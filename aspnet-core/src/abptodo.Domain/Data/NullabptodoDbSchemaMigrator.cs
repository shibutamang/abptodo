using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abptodo.Data
{
    /* This is used if database provider does't define
     * IabptodoDbSchemaMigrator implementation.
     */
    public class NullabptodoDbSchemaMigrator : IabptodoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}