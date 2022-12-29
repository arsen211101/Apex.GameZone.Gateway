using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.UoW;
using AutoMapper;

namespace Apex.GameZone.Core.Services.GameZone
{
    internal class SectionService : CommonService<SectionModel, SectionEntity>, ISectionService
    {
        public SectionService(IUnitOfWork uow,
                            IMapper mapper) : base(uow, mapper)
        {
        }
    }
}