using System.Collections.Generic;
using System.Threading.Tasks;
using Apex.GameZone.API.ViewModels.Item;
using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Item;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Apex.GameZone.API.Controllers;

[Route("api/v1/item")]
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
        var item = await _itemService.GetById(id);
        return Ok(_mapper.Map<ItemViewModel>(item));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var items = await _itemService.GetAll();
        return Ok(_mapper.Map<List<ItemViewModel>>(items));
    }

    [HttpPost]
    public async Task<IActionResult> CreateItem(ItemViewModel itemViewModel)
    {
        var items = await _itemService.Add(_mapper.Map<ItemModel>(itemViewModel));
        return Ok(items);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteItem(ItemViewModel itemViewModel)
    {
        await _itemService.Delete(_mapper.Map<ItemModel>(itemViewModel));
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateItem(ItemViewModel itemViewModel)
    {
        await _itemService.Update(_mapper.Map<ItemModel>(itemViewModel));
        return Ok();
    }
}