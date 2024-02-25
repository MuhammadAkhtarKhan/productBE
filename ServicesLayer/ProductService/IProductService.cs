using DomainLayer.Models.ProductModel;
using RepositoryLayer.IRepositories;
using ServicesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductService
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int Id);
        Task<Product> DeleteAsync(int Id);
        Task <Product> InsertProductAsync(ProductDTO entity);
        Task <Product> UpdateProductAsync(Product entity);
 
    }
}
