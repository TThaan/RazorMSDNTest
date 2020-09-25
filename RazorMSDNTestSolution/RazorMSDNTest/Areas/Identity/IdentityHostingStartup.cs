using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorMSDNTest.Data;

[assembly: HostingStartup(typeof(RazorMSDNTest.Areas.Identity.IdentityHostingStartup))]
namespace RazorMSDNTest.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RazorMSDNTestUsersDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RazorMSDNTestUsersDbContextConnection")));

                services.AddDefaultIdentity<RazorMSDNTestUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<RazorMSDNTestUsersDbContext>();
            });
        }
    }
}