using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
//https://learn-blazor.com/pages/layouts/
namespace WebApplication12
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
