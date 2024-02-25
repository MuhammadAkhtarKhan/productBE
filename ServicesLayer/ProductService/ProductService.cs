using DomainLayer.Models.ProductModel;
using RepositoryLayer.IRepositories;
using ServicesLayer.DTOs;

namespace ServicesLayer.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Product> DeleteAsync(int id)
        {
            Product product = await _repository.GetByIdAsync(id);
            if (product == null) return null;
          
             await _repository.DeleteAsync(product);
             await _repository.SaveChangesAsync();
           
            return product;
            
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task<Product> InsertProductAsync(ProductDTO cls)
        {
            Product product = new Product()
            {
                Id=0,
                Name = cls.Name,
                Description = cls.Description,
                ProductCategoryId = cls.ProductCategoryId,
                CreatedDate = DateTime.Now.ToString("MM-dd-yyyy")
            };
            await _repository.InsertAsync(product);
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product entity)
        {
            if (entity.Id <= 0) return null;
            //var prod=_repository.GetByIdAsync(entity.ProductId);
            //   if (prod == null) return null;
            //Product product = new Product()
            //{
            //    Id = entity.Id,
            //    Name = entity.Name,
            //    ProductDescription = entity.ProductDescription,
            //    ProductCategoryId = entity.ProductCategoryId,
            //    ModifiedDate = entity.ModifiedDate,
            //    CreatedDate=entity.CreatedDate
            //};

            await _repository.UpdateAsync(entity);
            return entity;
        }
    }
}
