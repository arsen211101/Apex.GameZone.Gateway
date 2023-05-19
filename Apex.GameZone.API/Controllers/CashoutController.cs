using Apex.GameZone.Core.Services.Checkout;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Apex.GameZone.API.ViewModels.CashRegister;

namespace Apex.GameZone.API.Controllers;

[Route("api/v1/cashregistery")]
[ApiController]
public class CashoutController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ICashoutService _cashoutService;

    public CashoutController(IMapper mapper, ICashoutService cashoutService)
    {
        _mapper = mapper;
        _cashoutService = cashoutService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var checks = await _cashoutService.GetById(id);
        return Ok(_mapper.Map<CashRegisterViewModel>(checks));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var cashRegister = await _cashoutService.GetAll();
        return Ok(_mapper.Map<List<CashRegisterViewModel>>(cashRegister));
    }

    [HttpPost]
    public async Task<IActionResult> AddCash(CashRegisterViewModel cashRegister)
    {
        var checks = await _cashoutService.Add(_mapper.Map<CashoutModel>(cashRegister));
        return Ok(checks);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCash(CashRegisterViewModel cashRegister)
    {
        await _cashoutService.Delete(_mapper.Map<CashoutModel>(cashRegister));
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCash(CashRegisterViewModel cashRegister)
    {
        await _cashoutService.Update(_mapper.Map<CashoutModel>(cashRegister));
        return Ok();
    }
}