using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Specifications.Common;

namespace Apex.GameZone.Data.Specifications.SectionSpecifications;

public class GetSectionsByGameZoneIdSpecification : CommonSpecification<SectionEntity>
{
    public GetSectionsByGameZoneIdSpecification(int id) : base(x => x.GameZoneId == id)
    {
    }
}