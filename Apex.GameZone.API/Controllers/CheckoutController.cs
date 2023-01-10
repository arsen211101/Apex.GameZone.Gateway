using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Checkout;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Apex.GameZone.API.ViewModels.Checkout;
using Apex.GameZone.Data.Specifications.GameZoneSpecifications;

namespace Apex.GameZone.API.Controllers;

[Route("api/v1/checkout")]
[ApiController]
public class CheckoutController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ICheckoutService _checkoutService;

    public CheckoutController(IMapper mapper, ICheckoutService checkoutService)
    {
        _mapper = mapper;
        _checkoutService = checkoutService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var checks = await _checkoutService.GetById(id);
        return Ok(_mapper.Map<CheckoutViewModel>(checks));
    }

    [HttpGet("sectionId/{sectionId}")]
    public async Task<IActionResult> GetLastBySectionId(int sectionId)
    {
        var checks = await _checkoutService.GetSingleBySpecification(new GetSingleCheckoutBySectionId(sectionId));
        return Ok(_mapper.Map<CheckoutViewModel>(checks));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var checkout = await _checkoutService.GetAll();
        return Ok(_mapper.Map<List<CheckoutViewModel>>(checkout));
    }

    [HttpPost]
    public async Task<IActionResult> AddCheck(CheckoutViewModel checkout)
    {
        var checks = await _checkoutService.Add(_mapper.Map<CheckoutModel>(checkout));
        return Ok(checks);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCheck(CheckoutViewModel checkout)
    {
        await _checkoutService.Delete(_mapper.Map<CheckoutModel>(checkout));
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCheck(CheckoutViewModel checkout)
    {
        await _checkoutService.Update(_mapper.Map<CheckoutModel>(checkout));
        return Ok();
    }
}