using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SportsStore.Models;

namespace SportsStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Создать службу хранилища, которая позволит контроллерам получать реализующие
            // интерфейс IProductRepository объекты, не зная, какой класс применяется.
                        services.AddTransient<IProductRepository, FakeProductRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //           Этот расширяющий метод отображает детали исключения,
            // которое произошло в приложении , что полезно во
            // время процесса разработки . Он не должен быть включен
            // в развернутых приложениях; в главе 12 будет показано,
            // как отключить данное средство
            app.UseDeveloperExceptionPage();

            //            Этот расширяющий метод добавляет простое сообще ние
            // в НТТР - ответы, которые иначе бы не имели тела,
            // такие как ответы 404 - Not Found(404 - не найдено)
            app.UseStatusCodePages();

            //            Этот расширяющий метод включает поддержку для
            // обслуживания статического содержимого из папки
            // wwwroot
            app.UseStaticFiles();

            //            Этот расширяющий метод включает инфраструктуру
            // ASP.NET Core MVC со стандартной конфигурацией
            // (которая позже в процессе разработки будет изменена)
            app.UseMvc(routes =>
            {
            });
        }
    }
}
