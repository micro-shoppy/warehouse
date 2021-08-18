using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Warehouse_Service.Repositories;

namespace Warehouse_Service.CQRS.Query
{
	public class ReadWarehouseProductsQueryHandler : IRequestHandler<ReadWarehouseProductsQuery, IEnumerable<WarehouseProduct>>
	{
		private readonly IWarehouseRepository _repo;
		public ReadWarehouseProductsQueryHandler(IWarehouseRepository repo)
		{
			_repo = repo;
		}
		public Task<IEnumerable<WarehouseProduct>> Handle(ReadWarehouseProductsQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_repo.ReadProducts());
		}
	}
}
