using System.Threading.Tasks;

namespace abptodo.Data
{
    public interface IabptodoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
