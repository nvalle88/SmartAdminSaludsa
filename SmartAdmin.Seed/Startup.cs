#region Using

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartAdmin.Data;
using SmartAdminSaludsa.Models;
using SmartAdminSaludsa.Models.Utiles;
using SmartAdminSaludsa.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using SmartAdminSaludsa.DBcontextPrestadores;

// ReSharper disable UnusedMember.Global
// ReSharper disable once ClassNeverInstantiated.Global

#endregion

namespace SmartAdminSaludsa
{
    /// <summary>
    /// Defines the startup instance used by the web host.
    /// </summary>

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

            var TiempoVidaCookie = Convert.ToDouble(Configuration.GetSection("TiempoVidaCookie").Value);

            services.AddDbContext<PrestadoresContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnectionBddPrestadores")));

            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<UserDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IEmailSender, EmailSender>();



            services.AddAuthorization(opts => {
                opts.AddPolicy("Administracion", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Administrador");
                });

                opts.AddPolicy("Gestion", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Gestor", "Administrador");
                });

                opts.AddPolicy("Gerencia", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Gerencia");
                });

                opts.AddPolicy("GerenciaGestion", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireRole("Gerencia", "Gestor", "Administrador");
                });
            });


            services.AddMvc();

            services.AddMemoryCache();

            services.AddSession();

            services.AddDistributedMemoryCache();

            services.AddResponseCaching();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            var defaultCulture = new CultureInfo("es-EC");
            defaultCulture.NumberFormat.NumberDecimalSeparator = ".";
            defaultCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            //defaultCulture.DateTimeFormat = DateTimeFormatInfo.CurrentInfo;
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<CultureInfo> { defaultCulture },
                SupportedUICultures = new List<CultureInfo> { defaultCulture },
                FallBackToParentCultures = false,
                FallBackToParentUICultures = false,
                RequestCultureProviders = new List<IRequestCultureProvider> { }
            });
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseSession();

            CreateRoles(serviceProvider);
            CreateUsers(serviceProvider);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseResponseCaching();
        }


        private void CreateRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] rolesName = new string[] { Perfiles.Administrador, Perfiles.Gerencia, Perfiles.Gestor };
            IdentityResult result;
            foreach (var item in rolesName)
            {
                var roleExist = roleManager.RoleExistsAsync(item).Result;
                if (!roleExist)
                {
                    //Se crean los roles si no existen en la BD
                    result = roleManager.CreateAsync(new IdentityRole(item)).Result;
                }
            }
        }

        private void CreateUsers(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var usersName = new ApplicationUser[]
            {
                new ApplicationUser { UserName = "yvalle@saludsa.com.ec", Email = "yvalle@saludsa.com.ec" },
                //new ApplicationUser { UserName = "yvalle@saludsa.com.ec", Email = "yvalle@saludsa.com.ec" },
                //new ApplicationUser { UserName = "yvalle@saludsa.com.ec", Email = "yvalle@saludsa.com.ec" },
            };
            IdentityResult result;
            foreach (var item in usersName)
            {
                var user = userManager.FindByNameAsync(item.UserName).Result;
                if (user == null)
                {
                    //Se crean los usuarios si no existen en la BD
                    switch (item.UserName)
                    {
                        case "yvalle@saludsa.com.ec": result = userManager.CreateAsync(item, "Administrador2018*").Result; break;
                        //case "gerencia@Saludsa.com.ec": result = userManager.CreateAsync(item, "Gerencia2021*").Result; break;
                        //case "gestor@saludsa.com.ec": result = userManager.CreateAsync(item, "Gestor2021*").Result; break;
                    }

                    switch (item.UserName)
                    {
                        case "yvalle@saludsa.com.ec": result = userManager.AddToRoleAsync(item, Perfiles.Administrador).Result; break;
                            //case "gerencia@bekaert.com": result = userManager.AddToRoleAsync(item, Perfiles.Gerencia).Result; break;
                            //case "gestor@bekaert.com": result = userManager.AddToRoleAsync(item, Perfiles.Gestor).Result; break;
                    }
                }

                //Se asignan los roles a los usuarios si no existen en la BD
               
            }
        }
    }
}
