using System.Collections.Generic;
using System.Threading.Tasks;
using Apex.GameZone.API.ViewModels;
using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.GameZone;
using Apex.GameZone.Data.Specifications.GameZoneSpecifications;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Apex.GameZone.Gateway.Controllers;

[Route("api/v1/gamezone")]
[ApiController]
public class GamezoneController : ControllerBase
{
    private readonly IGameZoneService _gameZoneService;
    private readonly IMapper _mapper;

    public GamezoneController(IGameZoneService gameZoneService, IMapper mapper)
    {
        _gameZoneService = gameZoneService;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var gameZone = await _gameZoneService.GetSingleBySpecification(new GetGameZoneSpecificationWithIncludes(id));
        return Ok(_mapper.Map<GameZoneViewModel>(gameZone));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var gameZones = await _gameZoneService.GetAll();
        return Ok(_mapper.Map<List<GameZoneViewModel>>(gameZones));
    }

    [HttpPost]
    public async Task<IActionResult> CreateGameZone(GameZoneViewModel gameZone)
    {
        var gameZones = await _gameZoneService.Add(_mapper.Map<GameZoneModel>(gameZone));
        return Ok(_mapper.Map<List<GameZoneViewModel>>(gameZones));
    }
}