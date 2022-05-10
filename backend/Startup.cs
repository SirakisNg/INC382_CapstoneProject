﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using backend.Models;

namespace backend;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    //public void ConfigureServices(IServiceCollection services)
    //{
    //    services.AddControllersWithViews();
    //}
    public void ConfigureServices(IServiceCollection services)
    {
        // Add framework services.  
        services.AddMvc();
        services.AddControllersWithViews;;
        service.AddSwaggerGen();

        services.Add(new ServiceDescriptor(typeof(DBContext), new DBContext(Configuration.GetConnectionString("DefaultConnection"))));
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

        //    app.UseMvc(routes =>
        //    {
        //        routes.MapRoute(
        //            name: "default",
        //            template: "{controller=Album}/{action=Index}/{id?}");
        //    });
        app.UseSwagger(); 
            app.UseSwaggerUI(c => { 
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V2"); 
        });
        



    }
    
}