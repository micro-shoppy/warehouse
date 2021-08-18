using System;
using MediatR;

namespace Microshoppy.Warehouse.CQRS.Query
{
	public class ReadWarehouseProductQuery : IRequest<WarehouseProduct>
	{
		public Guid ProductId { get; set; }
	}
}
