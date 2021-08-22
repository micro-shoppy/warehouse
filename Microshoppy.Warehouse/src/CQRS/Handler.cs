using Microshoppy.Warehouse.Repositories;

namespace Microshoppy.Warehouse.CQRS
{
	public class Handler
	{
		protected readonly IWarehouseRepository _repo;

		public Handler(IWarehouseRepository repo)
		{
			_repo = repo;
		}
	}
}
