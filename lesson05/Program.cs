using Microsoft.Extensions.DependencyInjection;
using System;

namespace lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILogger, Logger>()
                .AddScoped<IFileService, FileService>()
                .AddScoped<Starter>()
                .BuildServiceProvider();

            serviceProvider.GetRequiredService<Starter>()
                .Run();
        }
    }
}
