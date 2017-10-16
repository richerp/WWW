using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WWW.Data;
using WWW.Models;
using WWW.Services;
using AiursoftBase;
using Microsoft.AspNetCore.Identity;

namespace WWW
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public bool IsDevelopment { get; set; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            IsDevelopment = env.IsDevelopment();
            if (IsDevelopment)
            {
                Values.Schema = "http";
            }
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConnectToAiursoftDatabase<WWWDbContext>("WWW", IsDevelopment);
            services.AddIdentity<WWWUser, IdentityRole>()
                .AddEntityFrameworkStores<WWWDbContext>()
                .AddDefaultTokenProviders();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, WWWDbContext dbContext)
        {
            if (IsDevelopment)
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvcWithDefaultRoute();
            app.UseAiursoftAuthentication(appId: "9379174274020d83d93c44cc3f682fdf", appSecret: "84ec92e2300882d2c3ef4509661bf121");
        }
    }
}
