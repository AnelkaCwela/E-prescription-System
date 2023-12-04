using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project2022.Models;
using Project2022.Models.Interface;
using Project2022.Models.Respotory;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Project2022.Models.DataModel;

namespace Project2022
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection Services)
        {
            Services.AddDbContext<DBCONTEX>(options => options.UseSqlServer(Configuration["NelsonMandelaUniversty:ConnectionString"]));
            Services.AddIdentity<UserModel, IdentityRoleModel>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;

                options.SignIn.RequireConfirmedEmail = false;
            })
                .AddEntityFrameworkStores<DBCONTEX>()
                .AddDefaultTokenProviders()
                ;
            Services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
.RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            })
                .AddXmlDataContractSerializerFormatters();
            Services.AddTransient<IProvinceModel, RespProvinceModel>();
            Services.AddTransient<IAdminUserModel, RespAdminModel>();
            Services.AddTransient<ICityModel, RespCityModel>();
            Services.AddTransient<IDispenceModel, RespDispenceModel>();
            Services.AddTransient<IDoctorAlertModel, RespDoctorAlertModel>();
            Services.AddTransient<IDoctorSpecializationModel, RespDoctorSpecializationModel>();
            Services.AddTransient<IDoctorUserModel, RespDoctorUserModel>();
            Services.AddTransient<IMedicalHistoryModel, RespMedicalHistoryModel>();
             Services.AddTransient<IDiagonosisModel, RespDiagonosisModel>();
            Services.AddTransient<IDosageFormModel, RespDosageFormModel>();
            Services.AddTransient<ICurrentVistModel, RespCurrentVistModel>();
            Services.AddTransient<IGanderModel, RespGanderModel>();
            Services.AddTransient<IMedicalPrectiseModel, RespMedicalPrectiseModel>();
            Services.AddTransient<IMedicationActiveIngredienceModel, RespMedicationActiveIngredienceModel>();
            Services.AddTransient<IMedicationCategory, RespMedicationCategory>();
            Services.AddTransient<IMedicationModel, RespMedicationModel>();
            Services.AddTransient<IPatientMedicationModel, RespPatientMedicationModel>();
            Services.AddTransient<IActiveIngredientModel, RespActiveIngredientModel>();
            Services.AddTransient<IPatientUserModel, RespPatientUserModel>();
            Services.AddTransient<IPharmacistUserModel, RespPharmacistUserModel>();
            Services.AddTransient<IPharmacModel, RespPharmacModel>();
            Services.AddTransient<IPharmacyAlertModel, RespPharmacyAlertModel>();
            Services.AddTransient<IPrescriptionModel, RespPrescriptionModel>();
           Services.AddRazorPages();
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
                app.UseExceptionHandler("/Error");
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
                    name: "default",
                    pattern: "{controller=Account}/{action=Index}/{id?}");
            });
        }
    }
}
