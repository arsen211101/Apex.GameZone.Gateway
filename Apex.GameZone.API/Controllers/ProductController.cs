using System.Collections.Generic;
using System.Threading.Tasks;
using Apex.GameZone.API.ViewModels.Product;
using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.GameZone;
using Apex.GameZone.Data.Specifications.GameZoneSpecifications;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Apex.GameZone.API.Controllers;

[Route("api/v1/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IProductService _productService;

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

    [HttpGet("gameZoneId/{gameZoneId}")]
    public async Task<IActionResult> GetAllByGamezoneId(int gameZoneId)
    {
        var products = await _productService.GetAll(new GetProductByGamezoneSpecification(gameZoneId));
        return Ok(_mapper.Map<List<ProductViewModel>>(products));
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductViewModel productViewModel)
    {
        var products = await _productService.Add(_mapper.Map<ProductModel>(productViewModel));
        return Ok(products);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteProduct(ProductViewModel productViewModel)
    {
        await _productService.Delete(_mapper.Map<ProductModel>(productViewModel));
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProduct(ProductViewModel productViewModel)
    {
        await _productService.Update(_mapper.Map<ProductModel>(productViewModel));
        return Ok();
    }
}