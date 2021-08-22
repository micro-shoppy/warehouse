using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microshoppy.Warehouse.Repositories;

namespace Microshoppy.Warehouse.CQRS.Query
{
	public class ReadWarehouseProductQueryHandler : Handler, IRequestHandler<ReadWarehouseProductQuery, WarehouseProduct>
	{
		public ReadWarehouseProductQueryHandler(IWarehouseRepository repo) : base(repo)
		{
		}
		public Task<WarehouseProduct> Handle(ReadWarehouseProductQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_repo.ReadProduct(request.ProductId));
		}

	}
}
