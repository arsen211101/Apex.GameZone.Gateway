using System.Collections.Generic;
using System.Threading.Tasks;
using Apex.GameZone.API.ViewModels.Section;
using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.GameZone;
using Apex.GameZone.Data.Specifications.SectionSpecifications;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Apex.GameZone.API.Controllers;

[Route("api/v1/section")]
[ApiController]
public class SectionController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ISectionService _sectionService;

    public SectionController(ISectionService sectionService, IMapper mapper)
    {
        _sectionService = sectionService;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var section = await _sectionService.GetById(id);
        return Ok(_mapper.Map<SectionViewModel>(section));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var sections = await _sectionService.GetAll();

        return Ok(_mapper.Map<List<SectionViewModel>>(sections));
    }

    [HttpGet("/gamezone/{id}")]
    public async Task<IActionResult> GetAllByGameZoneId(int id)
    {
        var sections = await _sectionService.GetSingleBySpecification(new GetSectionsByGameZoneIdSpecification(id));
        return Ok(_mapper.Map<List<SectionViewModel>>(sections));
    }

    [HttpPost]
    public async Task<IActionResult> CreateSection(SectionViewModel sectionViewModel)
    {
        var sections = await _sectionService.Add(_mapper.Map<SectionModel>(sectionViewModel));
        return Ok(sections);
    }

    [HttpDelete]
    public async Task DedleteSection(SectionViewModel sectionViewModel)
    {
        await _sectionService.Delete(_mapper.Map<SectionModel>(sectionViewModel));
    }

    [HttpPut]
    public async Task UpdateSection(SectionViewModel sectionViewModel)
    {
        await _sectionService.Update(_mapper.Map<SectionModel>(sectionViewModel));
    }
}