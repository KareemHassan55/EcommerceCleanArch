using ApplicationService.E_CommerceProject.Abstract;
using ApplicationService.E_CommerceProject.Implementation;
using EntityFrameWork.E_CommerceProject.Abstract;
using EntityFrameWork.E_CommerceProject.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationService.E_CommerceProject
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IProductAppservice, ProductAppservice>();
            services.AddTransient<ICategoryAppservice, CategoryAppservice>();
            return services;
        }
    }
}
