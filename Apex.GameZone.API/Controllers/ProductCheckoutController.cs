using Apex.GameZone.API.ViewModels.Checkout;
using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Checkout;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apex.GameZone.API.Controllers
{
    [Route("api/v1/productCheckout")]
    [ApiController]
    public class ProductCheckoutController : ControllerBase
    {
        private readonly IProductCheckoutService _productCheckoutService;
        private readonly IMapper _mapper;

        public ProductCheckoutController(IMapper mapper, IProductCheckoutService productCheckoutService)
        {
            _mapper = mapper;
            _productCheckoutService = productCheckoutService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToCheck(ProductCheckoutViewModel productCheckout)
        {
            var productChecks = await _productCheckoutService.Add(_mapper.Map<ProductCheckoutModel>(productCheckout));
            return Ok(productChecks);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCheck(ProductCheckoutViewModel productCheckout)
        {
            await _productCheckoutService.Delete(_mapper.Map<ProductCheckoutModel>(productCheckout));
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCheck(ProductCheckoutViewModel productCheckout)
        {
            await _productCheckoutService.Update(_mapper.Map<ProductCheckoutModel>(productCheckout));
            return Ok();
        }
    }
}
