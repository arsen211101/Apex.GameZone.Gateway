using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Specifications.Common;

namespace Apex.GameZone.Data.Specifications.GameZoneSpecifications;

public class GetProductByGamezoneSpecification : CommonSpecification<ProductEntity>
{
    public GetProductByGamezoneSpecification(int Id) : base(x => x.GameZoneId == Id)
    {

    }
}