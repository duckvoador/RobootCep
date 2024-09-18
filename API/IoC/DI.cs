using Application.Services;
using Domains.Interfaces.Repository;
using Domains.Interfaces.Services;
using Infraestructure;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.IoC
{
    public static class DI
    {
        public static void AddSdk(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddDbContext<ProjectDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });   
        }
    }
}
