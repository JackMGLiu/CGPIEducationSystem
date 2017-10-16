using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CGPI.Web.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QJ.Framework.Entity.DbContext;
using QJ.Framework.Service.DTO;
using QJ.Framework.Service.Impl;
using QJ.Framework.Service.Interface;

namespace CGPI.Web
{
    public class Startup
    {
        //AutoMapper
        private MapperConfiguration _mapperConfiguration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfileConfiguration());
            });
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //数据库链接
            var connection = Configuration.GetConnectionString("SqlServerConnection");
            services.AddDbContextPool<CGPIDbContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("CGPI.Web")));

            //工作单元
            services.AddUnitOfWork<CGPIDbContext>();

            //DI
            AddDependencies(services);

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver =
                    new Newtonsoft.Json.Serialization.DefaultContractResolver();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "area",
                    template: "{area:exists}/{controller=Demo}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Login}/{id?}");
            });

            ServiceLocator.Instance = app.ApplicationServices;
        }

        private IServiceCollection AddDependencies(IServiceCollection services)
        {
            //AutoMapper
            services.AddSingleton<IMapper>(sp => _mapperConfiguration.CreateMapper());
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//用于获取请求上下文

            services.AddScoped<ISysUserService, SysUserService>();
            services.AddScoped<ISysRoleService, SysRoleService>();

            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
