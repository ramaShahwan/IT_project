using AutoMapper;
using ITE_Project.Repo.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyDbProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITE_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ScholarshipProfile).Assembly);
            services.AddAutoMapper(typeof(Std_ScholarshipProfile).Assembly);
            services.AddAutoMapper(typeof(UniversityProfile).Assembly);
            services.AddAutoMapper(typeof(UserProfile).Assembly);
            //services.AddAutoMapper(typeof();
            //services.AddAutoMapper(typeof();
            //services.AddAutoMapper(typeof();
            //services.AddAutoMapper(typeof();
            //services.AddAutoMapper(typeof();
            //services.AddAutoMapper(typeof();
            services.AddControllers();
            services.AddMvc();
            services.AddDbContext<MyDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("Defaultconnection"),

                        b => b.MigrationsAssembly(typeof(MyDbContext).Assembly.FullName)));

          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
