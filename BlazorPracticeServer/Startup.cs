using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Models.Configuration;
using BlazorPracticeServer.Services;
using BlazorStrap;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RESTFulSense.Clients;
using System;
using BlazorPracticeServer.Auth;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorPracticeServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //add blazorstrap
            services.AddBootstrapCss();

            services.AddRazorPages();
            services.AddServerSideBlazor();


            AddServices(services);

            services.AddSingleton<IApiBroker, ApiBroker>();

            services.AddHttpClient<IRESTFulApiFactoryClient, RESTFulApiFactoryClient>(client =>
            {
                LocalConfigurations localConfigurations = Configuration.Get<LocalConfigurations>();
                string apiUrl = localConfigurations.ApiConfigurations.Url;
                client.BaseAddress = new Uri(apiUrl);
            });

            AddAuthServices(services);
        }

        private static void AddAuthServices(IServiceCollection services)
        {
            services.AddAuthorizationCore();

            // tying two services to one instance.
            services.AddScoped<JWTAuthenticationStateProvider>();
            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());
            services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IAccountsService, AccountsService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
