using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Warehouse_Service.Repositories;

namespace Warehouse_Service.CQRS.Command
{
	public class CreateWarehouseProductCommandHandler : Handler, IRequestHandler<CreateWarehouseProductCommand, Unit>
	{
		public CreateWarehouseProductCommandHandler(IWarehouseRepository repository) : base(repository)
		{
		}

		public Task<Unit> Handle(CreateWarehouseProductCommand request, CancellationToken cancellationToken)
		{
			var productToCreate = new WarehouseProduct()
			{
				ProductId = request.ProductId,
				Stock = request.Stock,
				Weight = request.Weight
			};
			_repo.CreateProduct(productToCreate);

			return Task.FromResult(Unit.Value);
		}
	}
}
