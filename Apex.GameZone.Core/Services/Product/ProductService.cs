using Apex.GameZone.Core.Entities;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.UoW;
using AutoMapper;

namespace Apex.GameZone.Core.Services.GameZone
{
    internal class ProductService : CommonService<ProductModel, ProductEntity>, IProductService
    {
        public ProductService(IUnitOfWork uow,
                            IMapper mapper) : base(uow, mapper)
        {
        }
    }
}