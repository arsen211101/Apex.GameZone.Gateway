using Apex.GameZone.API.ViewModels.CashRegister;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Repositories.UoW;
using AutoMapper;

namespace Apex.GameZone.Core.Services.Checkout;

internal class CashoutService : CommonService<CashoutModel, CashoutEntity>, ICashoutService
{
    public CashoutService(IUnitOfWork uow,
        IMapper mapper) : base(uow, mapper)
    {
    }
}