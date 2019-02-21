using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProfessionalPortfolio.Mapping;
using Microsoft.EntityFrameworkCore;
using ProfessionalPortfolio.DataAccess.Repositories;
using ProfessionalPortfolio.DataAccess;
using ProfessionalPortfolio.Model.Models;
using ProfessionalPortfolio.BusinessLogic.Services;

namespace ProfessionalPortfolio
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
            services.AddAutoMapper(cfg => cfg.AddProfile(new MappingProfile()));
            services.AddDbContext<PortfolioDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWorkingExperienceRepository, WorkingExperienceRepository>();

            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWorkingExperienceService, WorkingExperienceService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
