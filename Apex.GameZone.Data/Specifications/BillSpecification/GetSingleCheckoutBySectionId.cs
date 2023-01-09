using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Specifications.Common;

namespace Apex.GameZone.Data.Specifications.GameZoneSpecifications;

public class GetSingleCheckoutBySectionId : CommonSpecification<CheckoutEntity>
{
    public GetSingleCheckoutBySectionId(int Id) : base(x => x.SectionId == Id && x.End == null)
    {

    }
}