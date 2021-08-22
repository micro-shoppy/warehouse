using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microshoppy.Warehouse.Repositories;

namespace Microshoppy.Warehouse.CQRS.Command
{
	public class UpdateWarehouseProductCommandHandler : Handler, IRequestHandler<UpdateWarehouseProductCommand, Unit>
	{
		public UpdateWarehouseProductCommandHandler(IWarehouseRepository repo) : base(repo)
		{
		}

		public Task<Unit> Handle(UpdateWarehouseProductCommand request, CancellationToken cancellationToken)
		{
			_repo.UpdateProduct(request.ProductId, new WarehouseProduct
			{
				ProductId = request.ProductId,
				Stock = request.Stock,
				Weight = request.Weight
			});
			return Task.FromResult(Unit.Value);
		}
	}
}
