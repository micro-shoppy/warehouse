using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microshoppy.Warehouse.Repositories;

namespace Microshoppy.Warehouse.CQRS.Command
{
	public class DeleteWarehouseProductCommandHandler : Handler, IRequestHandler<DeleteWarehouseProductCommand, Unit>
	{
		public DeleteWarehouseProductCommandHandler(IWarehouseRepository repo) : base(repo)
		{
		}

		public Task<Unit> Handle(DeleteWarehouseProductCommand request, CancellationToken cancellationToken)
		{
			_repo.DeleteProduct(request.ProductId);
			return Task.FromResult(Unit.Value);
		}
	}
}
