using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Repository;
using DataAccess.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApiTodo
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
            services.AddSingleton<IOrderService, OrderService>();
            services.AddSingleton<IOrderRepository>(c => new OrderRepository(Configuration["ConnectionString"]));

            services.AddSingleton<IAdminService, AdminService>();
            services.AddSingleton<IAdminRepository>(c => new AdminRepository(Configuration["ConnectionString"]));

            services.AddSingleton<ICustomerService, CustomerService>();
            services.AddSingleton<ICustomerRepository>(c => new CustomerRepository(Configuration["ConnectionString"]));

            services.AddSingleton<IHistoryOrderService, HistoryOrderService>();
            services.AddSingleton<IHistoryOrderRepository>(c => new HistoryOrderRepository(Configuration["ConnectionString"]));

            services.AddSingleton<IOrderOverViewService, OrderOverViewService>();
            services.AddSingleton<IOrderOverViewRepository>(c => new OrderOverViewRepository(Configuration["ConnectionString"]));

            services.AddSingleton<IActiveOrderViewService, ActiveOrderViewService>();
            services.AddSingleton<IActiveOrderViewRepository>(c => new ActiveOrderViewRepository(Configuration["ConnectionString"]));

            services.AddSingleton<IPayMentDetailsService, PayMentDetailsService>();
            services.AddSingleton<IPayMentDetailsRepository>(c => new PayMentDetailsRepository(Configuration["ConnectionString"]));

            services.AddSingleton<IOperatorService, OperatorService>();
            services.AddSingleton<IOperatorRepository>(c => new OperatorRepository(Configuration["ConnectionString"]));

            services.AddCors(o => {
                o.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

       

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            
            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");
            app.UseRouting();

            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
