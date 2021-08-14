using System;
using System.Collections.Generic;

namespace Warehouse_Service.Repositories
{
	public interface IWarehouseRepository
	{
		WarehouseProduct CreateProduct(WarehouseProduct product);
		WarehouseProduct ReadProduct(Guid productId);
		IEnumerable<WarehouseProduct> ReadProducts();
		WarehouseProduct UpdateProduct(Guid productId, WarehouseProduct product);
		void DeleteProduct(Guid productId);
	}
}
