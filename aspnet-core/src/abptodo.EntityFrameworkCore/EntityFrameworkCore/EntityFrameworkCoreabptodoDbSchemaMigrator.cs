using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abptodo.Data;
using Volo.Abp.DependencyInjection;

namespace abptodo.EntityFrameworkCore
{
    public class EntityFrameworkCoreabptodoDbSchemaMigrator
        : IabptodoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreabptodoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the abptodoDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<abptodoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
