using System.Collections.Generic;
using MediatR;

namespace Microshoppy.Warehouse.CQRS.Query
{
	public class ReadWarehouseProductsQuery : IRequest<IEnumerable<WarehouseProduct>>
	{

	}
}
