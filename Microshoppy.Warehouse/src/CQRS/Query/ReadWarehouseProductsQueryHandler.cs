using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microshoppy.Warehouse.Repositories;

namespace Microshoppy.Warehouse.CQRS.Query
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
