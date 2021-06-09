using System;
using BlogSystem.Areas.Identity.Data;
using BlogSystem.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BlogSystem.Areas.Identity.IdentityHostingStartup))]
namespace BlogSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<BlogSystemIdentityDbContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("BlogSystemIdentityDbContextConnection")));

                //services.AddIdentityCore<ApplicationUser>()
                //          .AddEntityFrameworkStores<BlogSystemIdentityDbContext>()
                //          .AddDefaultUI();
                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<BlogSystemIdentityDbContext>();
            });
        }
    }
}