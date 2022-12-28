using Apex.GameZone.API.ViewModels.Product;
using Apex.GameZone.Core.Services.GameZone;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apex.GameZone.API.Controllers
{
    [Route("api/v1/section")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        private readonly IMapper _mapper;

        public SectionController(ISectionService sectionService, IMapper mapper)
        {
            _sectionService = sectionService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _sectionService.GetById(id);

            return Ok(_mapper.Map<ProductViewModel>(product));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _sectionService.GetAll();

            return Ok(_mapper.Map<List<ProductViewModel>>(products));
        }
    }
}
