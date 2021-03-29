using Flauddid.Client.DataAccess;
using Flauddid.Domain;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Flauddid.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient 
            { 
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
            });
            
            builder.Services.AddScoped<IPostService, PostService>();
            builder.Services.AddScoped<ICommentsService, CommentsService>();
            builder.Services.AddScoped<ISubRedditService, SubRedditService>();

            await builder.Build().RunAsync();
        }
    }
}
