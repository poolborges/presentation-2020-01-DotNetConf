using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Threading;

namespace FlightFinder.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            CreateHostBuilder(args).Build().RunAsync();
        }

        public static WebAssemblyHostBuilder CreateHostBuilder(string[] args) {

            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            Startup startup = new Startup();

            startup.ConfigureServices(builder.Services);
            startup.Configure(builder.RootComponents);

            return builder;
        }
            
    }
}
