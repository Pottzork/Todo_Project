using BlazorTodo.Models;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorTodo.Pages.OrderPages
{
    public class ActiveOrdersBase : ComponentBase
    {
        HttpClient Http = new HttpClient();

        public Orders[] orders;

        protected override async Task OnInitializedAsync() => await GetOrders();

        private async Task GetOrders() => orders = await Http.GetFromJsonAsync<Orders[]>("https://localhost:44374/api/Orders");
    }
}
