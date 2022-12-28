using Apex.GameZone.API.ViewModels.Product;
using Apex.GameZone.Core.Entities;
using Apex.GameZone.Core.Services.GameZone;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apex.GameZone.API.Controllers
{
    [Route("api/v1/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetById(id);
            return Ok(_mapper.Map<ProductViewModel>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAll();
            return Ok(_mapper.Map<List<ProductViewModel>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel productViewModel)
        {
            var products = await _productService.Add(_mapper.Map<ProductModel>(productViewModel));
            return Ok(products);
        }

        [HttpDelete]
        public async Task DeleteProduct(ProductViewModel productViewModel)
        {
            await _productService.Delete(_mapper.Map<ProductModel>(productViewModel));
        }

        [HttpPut]
        public async Task UpdateProduct(ProductViewModel productViewModel)
        {
            await _productService.Update(_mapper.Map<ProductModel>(productViewModel));
        }
    }
}
