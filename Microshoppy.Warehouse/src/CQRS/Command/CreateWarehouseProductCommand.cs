using System;
using MediatR;

namespace Microshoppy.Warehouse.CQRS.Command
{
	public class CreateWarehouseProductCommand : IRequest<Unit>
	{
		public Guid ProductId { get; set; }
		public int Stock { get; set; }
		public double Weight { get; set; }
	}
}
