using LetsMusic.Domain;
using LetsMusic.Presentation.ProgramFlow;
using LetsMusic.Repositories;
using LetsMusic.Repositories.Base;
using LetsMusic.Repositories.Interfaces;
using LetsMusic.Services;
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
            var registrationFlow = serviceProvider.GetService<IRegistrationFlow>();

            registrationFlow.RegistrationMenu();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IRegistrationFlow, RegistrationFlow>()
                .AddScoped<ITeacherServices, TeacherServices>()
                .AddScoped<ITeacherRepository, TeacherRepository>()
                .AddScoped<IBaseRepository<Teacher>, BaseRepository<Teacher>>();
        }
    }
}