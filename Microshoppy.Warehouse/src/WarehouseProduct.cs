using System;

namespace Microshoppy.Warehouse
{
	public class WarehouseProduct
	{
		public Guid ProductId { get; set; }
		public int Stock { get; set; }
		public double Weight { get; set; }
	}
}
