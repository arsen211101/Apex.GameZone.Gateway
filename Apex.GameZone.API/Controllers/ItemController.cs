using Apex.GameZone.API.ViewModels;
using Apex.GameZone.API.ViewModels.Item;
using Apex.GameZone.API.ViewModels.Product;
using Apex.GameZone.Core.Entities;
using Apex.GameZone.Core.Services.GameZone;
using Apex.GameZone.Core.Services.Item;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Specifications.GameZoneSpecifications;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apex.GameZone.Gateway.Controllers
{
    [Route("api/v1/Item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public ItemController(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _itemService.GetById(id);
            return Ok(_mapper.Map<ProductViewModel>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _itemService.GetAll();
            return Ok(_mapper.Map<List<ProductViewModel>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ItemViewModel itemViewModel)
        {
            var products = await _itemService.Add(_mapper.Map<ItemModel>(itemViewModel));
            return Ok(products);
        }

        [HttpDelete]
        public async Task DeleteProduct(ItemViewModel itemViewModel)
        {
            await _itemService.Delete(_mapper.Map<ItemModel>(itemViewModel));
        }

        [HttpPut]
        public async Task UpdateProduct(ItemViewModel itemViewModel)
        {
            await _itemService.Update(_mapper.Map<ItemModel>(itemViewModel));
        }
    }
}
