
using DomainLayer.Models.ProductModel;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.DTOs;
using ServicesLayer.ProductService;

namespace Products.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            return Ok(result);
        }
        [HttpGet(nameof(GetProductById))]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _productService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost(nameof(InsertProduct))]
        public async Task<IActionResult> InsertProduct(ProductDTO cls)
        {      

            await _productService.InsertProductAsync(cls);
            return Ok("Data inserted");
        }

        

        [HttpPut(nameof(UpdateProduct))]
        public async Task<IActionResult> UpdateProduct(Product cls)
        {
         var prod=   await _productService.UpdateProductAsync(cls);
            if(prod == null)
            {
                return BadRequest("Product is not updated");
            }
            return Ok("Data updated");
        }
        
        [HttpDelete(nameof(DeleteProduct))]
        public async Task<IActionResult> DeleteProduct(int id)
        {
         var product=   await _productService.DeleteAsync(id);
            if (product == null)
            {
                string res = $"Product with id={id} not found";
                return  BadRequest(res);
            }

            return Ok("Product Deleted");
        }
    }
}
