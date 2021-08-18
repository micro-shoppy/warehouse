using System;
using MediatR;

namespace Microshoppy.Warehouse.CQRS.Command
{
	public class DeleteWarehouseProductCommand : IRequest<Unit>
	{
		public Guid ProductId { get; set; }

	}
}
