using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FormationAspNet5.Interfaces;
using FormationAspNet5.Models;
using FormationAspNet5.Repositories;
using FormationAspNet5.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace FormationAspNet5.Tools
{
    public static class Extension
    {

        public static void UseOurCookie(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                context.Request.Cookies.Append(new KeyValuePair<string, string>("toto", "tata"));
                context.Response.Cookies.Append("titi", "value titi");
                await next.Invoke();
            });
        }

        public static void UseLogger(this IApplicationBuilder app, string path)
        {

            app.Use(async (context, next) =>
            {
                StreamWriter writer = new StreamWriter(path);
                writer.WriteLine($"URL : {context.Request.QueryString}, Verb : {context.Request.Method}");
                writer.Close();
                await next.Invoke();
            }); 
        }


        public static void AddOurServices(this IServiceCollection services)
        {
            services.AddTransient<ITestTransientService, UniqueId2Service>();
            services.AddTransient<SecondService>();
            services.AddSingleton<ITestSignletonService, UniqueId2Service>();
            services.AddScoped<ITestScopedService, UniqueId2Service>();
            services.AddScoped<IHash, HashService>();
        }


        public static void AddRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Person>, PersonRepository>();
        }
    }
}
