using System.Collections.Generic;
using MediatR;

namespace Warehouse_Service.CQRS.Query
{
	public class ReadWarehouseProductsQuery : IRequest<IEnumerable<WarehouseProduct>>
	{

	}
}
