using Warehouse_Service.Repositories;

namespace Warehouse_Service.CQRS
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
