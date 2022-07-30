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
            var mainFlow = serviceProvider.GetService<IMainFlow>();

            mainFlow.BeginApp();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<ISearchFlow, SearchFlow>()
                .AddScoped<IRegistrationFlow, RegistrationFlow>()
                .AddScoped<ISearchServices, SearchServices>()
                .AddScoped<IRegistrationServices, RegistrationServices>()
                .AddScoped<IStudentRepository, StudentRepository>()
                .AddScoped<ITeacherRepository, TeacherRepository>()
                .AddScoped<IBaseRepository, BaseRepository>();
        }
    }
}