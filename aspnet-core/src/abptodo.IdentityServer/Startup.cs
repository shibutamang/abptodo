using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace abptodo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<abptodoIdentityServerModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
