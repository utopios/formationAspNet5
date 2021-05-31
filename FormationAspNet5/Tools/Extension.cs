﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Builder;

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
    }
}
