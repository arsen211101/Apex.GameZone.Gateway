using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.UoW;
using AutoMapper;

namespace Apex.GameZone.Core.Services.Checkout;

internal class CheckoutService : CommonService<CheckoutModel, CheckoutEntity>, ICheckoutService
{
    public CheckoutService(IUnitOfWork uow,
        IMapper mapper) : base(uow, mapper)
    {
    }
}