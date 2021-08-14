using System;
using MediatR;

namespace Warehouse_Service.CQRS.Command
{
	public class UpdateWarehouseProductCommand : IRequest<Unit>
	{
		public Guid ProductId { get; set; }
		public int Stock { get; set; }
		public double Weight { get; set; }

	}
}
