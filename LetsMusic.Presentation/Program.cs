using Microsoft.Extensions.DependencyInjection;

namespace LetsMusic.Presentation
{
    public class Program
    {
        static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var mainFlow = serviceProvider.GetService<IMainFlow>();

            mainFlow.BeginApp();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<ITaxCalculator, TaxCalculator>()
                .AddScoped<IPersonTaxInfoRepository, PersonTaxInfoRepository>()
                .AddScoped<IBaseRepository<Person>, BaseRepository<Person>>();
        }
    }
}