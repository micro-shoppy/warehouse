using System;
using MediatR;

namespace Warehouse_Service.CQRS.Query
{
	public class ReadWarehouseProductQuery : IRequest<WarehouseProduct>
	{
		public Guid ProductId { get; set; }
	}
}
