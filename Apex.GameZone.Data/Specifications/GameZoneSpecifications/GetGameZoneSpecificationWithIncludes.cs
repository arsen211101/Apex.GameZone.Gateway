using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Specifications.Common;

namespace Apex.GameZone.Data.Specifications.GameZoneSpecifications;

public class GetGameZoneSpecificationWithIncludes : CommonSpecification<GameZoneEntity>
{
    public GetGameZoneSpecificationWithIncludes(int Id) : base(x => x.Id == Id)
    {
        AddInclude(x => x.Sections);
        AddInclude(x => x.Products);
        AddInclude(x => x.Items);
    }
}