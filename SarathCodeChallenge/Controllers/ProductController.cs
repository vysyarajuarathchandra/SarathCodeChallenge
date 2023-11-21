using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SarathCodeChallenge.DTOs;
using SarathCodeChallenge.Entites;
using SarathCodeChallenge.Services;

namespace SarathCodeChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        public ProductController(IProductService productService, IMapper mapper, IConfiguration configuration)
        {
            this.productService = productService;
            this.mapper = mapper;
            this.configuration = configuration;
        }
        [HttpGet,Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            try
            {
                List<Product> products = productService.GetAllProducts();
                List<ProductDTO> productDTO = mapper.Map<List<ProductDTO>>(products);
                return StatusCode(200, productDTO);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost,Route("AddProducts")]
        public IActionResult AddProduct([FromBody] ProductDTO productDTO)
        {
            try
            {
                Product product = mapper.Map<Product>(productDTO);
                productService.AddProduct(product);
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut,Route("EditProduct")]
        public IActionResult Edit(ProductDTO productDTO)
        {
            try
            {
                Product product = mapper.Map<Product>(productDTO);
                productService.UpdateProduct(product);
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete,Route("DeleteProduct/{productid}")]
        public IActionResult Delete(int productid)
        {
            try
            {
                productService.DeleteProduct(productid);
                return StatusCode(200);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
