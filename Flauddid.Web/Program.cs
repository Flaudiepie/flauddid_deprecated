using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            var configuration = builder.Configuration;
            var webAgentPool = new RedditSharp.RefreshTokenWebAgentPool(configuration["RedditClientID"],
                                                                        configuration["RedditClientSecret"],
                                                                        configuration["RedditRedirectURI"])
            {
                DefaultRateLimitMode = RedditSharp.RateLimitMode.Burst,
                DefaultUserAgent = "SnooNotes (by Meepster23)"
            };
            builder.Services.AddSingleton(webAgentPool);
            await builder.Build().RunAsync();
        }
    }
}
