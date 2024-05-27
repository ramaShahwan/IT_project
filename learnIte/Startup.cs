
using AutoMapper;
using ITE_Project.IRepo;
using ITE_Project.Repo;
using ITE_Project.Repo.Profiles;
using ITE_Project.Repo.Profiles.Stored_ProceduresProfiles;
using learnIte.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyDbProject;
using MyTables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnIte
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
            services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("Def")));

            services.AddIdentity<UserEntity, IdentityRole<int>>(options => {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(10);
            })
           .AddDefaultTokenProviders()
           .AddDefaultUI()
           .AddEntityFrameworkStores<MyDbContext>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddControllersWithViews();
            services.AddCloudscribePagination();
            services.AddScoped<IStudentRepo, StudentRepo>();
            services.AddScoped<IScholarshipRepo, ScholarshipRepo>();
            services.AddScoped<IOpinionRepo, OpinionRepo>();
            services.AddScoped<IStd_ScholarshipRepo, Std_ScholarsipRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IUniversityRepo, UniversityRepo>();
            services.AddScoped<IStudent_LTRepo, Student_LTRepo>();
            services.AddScoped<ILearn_TrackRepo, Learn_TrackRepo>();
            services.AddScoped<ICourseRepo, CourseRepo>();
            services.AddScoped<ICourse_LTRepo, Course_LTRepo>();
            services.AddScoped<IStored_ProceduresRepo, Stored_ProceduresRepo>();
            services.AddAutoMapper(typeof(Course_LTProfile).Assembly);
            services.AddAutoMapper(typeof(CourseProfile).Assembly);
            services.AddAutoMapper(typeof(Learn_TrackProfile).Assembly);
            services.AddAutoMapper(typeof(UserProfile).Assembly);
            services.AddAutoMapper(typeof(OpinionProfile).Assembly);
            services.AddAutoMapper(typeof(ScholarshipProfile).Assembly);
            services.AddAutoMapper(typeof(Std_ScholarshipProfile).Assembly);
            services.AddAutoMapper(typeof(Student_LTProfile).Assembly);
            services.AddAutoMapper(typeof(UniversityProfile).Assembly);
            services.AddAutoMapper(typeof(StudentProfile).Assembly);
            services.AddAutoMapper(typeof(Stored_ProceduresProfiles).Assembly);
            services.AddRazorPages().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                   pattern: "{area:exists}/{controller=CourseEntity}/{action=Index}/{id?}"
                   );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
