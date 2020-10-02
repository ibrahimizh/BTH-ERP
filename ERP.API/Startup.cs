using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.API.Data;
using ERP.API.Data.Services;
using ERP.API.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ERP.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            StaticConfig = configuration;
        }

        public IConfiguration Configuration { get; }
        public static IConfiguration StaticConfig { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddIdentityServer()
                    .AddDeveloperSigningCredential()
                    .AddTestUsers(Config.GetUsers())
                    .AddInMemoryIdentityResources(Config.GetIdentityResources())
                    .AddInMemoryClients(Config.GetClients());


            services.Configure<ConfigurationSettings>(Configuration.GetSection("Settings"));
            services.AddTransient<IDbContext,DbContext>();
            services.AddTransient<IMaterialsService,MaterialsService>();
            services.AddTransient<ISuppliersService,SuppliersService>();
            services.AddTransient<IEmployeesService,EmployeesService>();
            services.AddTransient<BusinessPartnerService>();
            services.AddTransient<PurchaseOrderService>();
            services.AddTransient<ProposalService>();
            services.AddTransient<WorkOrderService>();
            services.AddTransient<ERPeventService>();
            services.AddTransient<AuthService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseIdentityServer();
            app.UseMvcWithDefaultRoute();
        }
    }
}
