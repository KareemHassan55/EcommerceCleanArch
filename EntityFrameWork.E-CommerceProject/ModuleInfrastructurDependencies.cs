using EntityFrameWork.E_CommerceProject.Abstract;
using EntityFrameWork.E_CommerceProject.InfrastructureBases;
using EntityFrameWork.E_CommerceProject.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.E_CommerceProject
{
    public static class ModuleInfrastructurDependencies
    {
        public static IServiceCollection AddInfrastrctreDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}
