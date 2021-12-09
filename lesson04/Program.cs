using Microsoft.Extensions.DependencyInjection;
using System;

namespace lesson04
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IAnimalRepository, AnimalRepository>()
                .AddScoped<ISection, Section>()
                .AddScoped<SectionUI>()
                .BuildServiceProvider();

            serviceProvider.GetRequiredService<SectionUI>()
                .Run();
        }
    }
}
