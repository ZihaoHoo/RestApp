﻿using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(RestApp.Server.Areas.Identity.IdentityHostingStartup))]
namespace RestApp.Server.Areas.Identity
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