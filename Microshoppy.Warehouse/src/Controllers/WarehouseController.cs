using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microshoppy.Warehouse.CQRS.Command;
using Microshoppy.Warehouse.CQRS.Query;

namespace Microshoppy.Warehouse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly ILogger<WarehouseController> _logger;
        private readonly IMediator _mediator;

        public WarehouseController(ILogger<WarehouseController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<WarehouseProduct>> ReadAllProducts()
        {
            return await _mediator.Send(new ReadWarehouseProductsQuery());
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<WarehouseProduct> ReadProduct(Guid productId)
        {
            return await _mediator.Send(new ReadWarehouseProductQuery
            {
                ProductId = productId
            });
        }

        [HttpPost]
        public void CreateProduct(WarehouseProduct product)
        {
            _mediator.Send(new CreateWarehouseProductCommand
            {
                ProductId = product.ProductId,
                Stock = product.Stock,
                Weight = product.Weight
            });
        }

        [HttpPost]
        [Route("{productId}")]
        public void UpdateProduct(Guid productId, WarehouseProduct product)
        {
            _mediator.Send(new UpdateWarehouseProductCommand
            {
                ProductId = productId,
                Stock = product.Stock,
                Weight = product.Weight
            });
        }

        [HttpDelete]
        [Route("{productId}")]
        public void DeleteProduct(Guid productId)
        {
            _mediator.Send(new DeleteWarehouseProductCommand
            {
                ProductId = productId
            });
        }
    }
}
