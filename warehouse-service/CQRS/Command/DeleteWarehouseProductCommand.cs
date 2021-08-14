using System;
using MediatR;

namespace Warehouse_Service.CQRS.Command
{
	public class DeleteWarehouseProductCommand : IRequest<Unit>
	{
		public Guid ProductId { get; set; }

	}
}
