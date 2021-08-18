using System;

namespace Warehouse_Service
{
	public class WarehouseProduct
	{
		public Guid ProductId { get; set; }
		public int Stock { get; set; }
		public double Weight { get; set; }
	}
}
