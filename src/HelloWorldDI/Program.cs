using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelloWorldDI
{
    internal class Program
    {
        private readonly HelloWorldService helloWorldService;

        private static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();
        }

        public Program(HelloWorldService helloWorldService)
        {
            this.helloWorldService = helloWorldService;
        }

        private void Run()
        {
            helloWorldService.Write("Just15");
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddScoped<Program>();
                    services.AddScoped<HelloWorldService>();
                });
        }
    }
}
