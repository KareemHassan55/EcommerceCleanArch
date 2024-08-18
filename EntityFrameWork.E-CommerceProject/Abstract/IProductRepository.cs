using EntityFrameWork.E_CommerceProject.InfrastructureBases;
 using Domain.ECommerceProject.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameWork.E_CommerceProject.Abstract
{
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {
        public Task<List<Product>> GetProductListAsync();

    }
}
