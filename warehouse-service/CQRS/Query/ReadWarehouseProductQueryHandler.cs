using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Warehouse_Service.Repositories;

namespace Warehouse_Service.CQRS.Query
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
