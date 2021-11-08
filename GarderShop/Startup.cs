using GarderShop.Data;
using GarderShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using GarderShop.Data.Interfaces;
using GarderShop.Data.Repository;

namespace GarderShop
{
    public class Startup
    {
        private IConfigurationRoot _conString;
        public Startup(IWebHostEnvironment hostEnv)
        {
            _conString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("Settings/DBSettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 26)); 
            
            string connectionString = _conString.GetConnectionString("DefaultConnection");
            
            services.AddDbContext<DBConnect>(c => c.UseMySql(connectionString, serverVersion));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DBConnect>();

            services.AddTransient<IAllProducts, ProductRepository>();
            services.AddTransient<IAllCategory, CategoryRepository>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //Используем MVC
            services.AddMvc();
            //Разная корзина для нескольких юзеров
            services.AddScoped(sp => ShopCart.GetCart(sp));
            //Юзаем кэш
            services.AddMemoryCache();
            //Юзаем сессии
            services.AddSession();


            //services.AddScoped(sp => ShopCart.GetCart(sp));
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // добавление данных
            /*using (DBConnect db = new DBConnect(_confString))
            {
                Product user1 = new Product { Name = "Tom", Price = 3300 };
                Product user2 = new Product { Name = "Alice", Price = 2600 };

                db.Products.AddRange(user1, user2);
                db.SaveChanges();
            }*/
            app.UseStatusCodePages();
            app.UseSession();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Default", "{controller=home}/{action=index}/{id?}");
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                DBConnect content = scope.ServiceProvider.GetRequiredService<DBConnect>();
                DBObjects.Inital(content);
            }
        }
    }
}
