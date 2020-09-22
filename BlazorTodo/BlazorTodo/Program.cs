using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorTodo.Data.Services;
using BlazorTodo.Data.Repositorys;

namespace BlazorTodo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //testcomment
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<IOrderServices, OrderServices>();
            builder.Services.AddSingleton<IOrderRepositorys>(c => new OrderRepository("https://localhost:44374/api/Orders"));


            await builder.Build().RunAsync();
        }
    }
}
