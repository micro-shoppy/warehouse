using System;
using System.Collections.Generic;
using System.Linq;

namespace Warehouse_Service.Repositories
{
	public class InMemoryWarehouseRepository : IWarehouseRepository
	{
		private static readonly List<WarehouseProduct> _repo = new();

		public WarehouseProduct CreateProduct(WarehouseProduct product)
		{
			Console.WriteLine("Creating product");
			_repo.Add(product);
			return product;
		}

		public WarehouseProduct ReadProduct(Guid productId)
		{
			Console.WriteLine("Reading product");
			return _repo.Find(p => p.ProductId == productId);
		}

		public IEnumerable<WarehouseProduct> ReadProducts()
		{
			Console.WriteLine("Reading all products");
			return _repo.AsEnumerable();
		}

		public WarehouseProduct UpdateProduct(Guid productId, WarehouseProduct product)
		{
			_repo.Remove(_repo.Find(p => p.ProductId == productId));
			_repo.Add(product);
			Console.WriteLine("Updating product");
			return product;
		}

		public void DeleteProduct(Guid productId)
		{
			Console.WriteLine("Deleting product");
			_repo.Remove(_repo.Find(p => p.ProductId == productId));
		}
	}
}
