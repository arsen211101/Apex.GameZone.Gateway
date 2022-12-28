﻿using Apex.GameZone.API.ViewModels;
using Apex.GameZone.Core.Entities;
using Apex.GameZone.Core.Services.GameZone;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apex.GameZone.Gateway.Controllers
{
    [Route("api/v1/Gamezone")]
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
            var gameZone = await _gameZoneService.GetById(id);

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
}