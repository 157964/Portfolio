using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Ticketsystem.Areas.Identity.IdentityHostingStartup))]
namespace Ticketsystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}