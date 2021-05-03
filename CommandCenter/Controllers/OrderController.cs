using CommandCenter.Entity;
using CommandCenter.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandCenter.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {
        private readonly IRepository<Order> repository;
        public OrderController(IRepository<Order> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetAsync()
        {
            var items = (await repository.GetAllAsync()).Select(a => a.AsDto());
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetByIdAsync(Guid id)
        {
            var item = await repository.GetAsync(id);
            if (item == null)
            {
                NotFound();
            }

            return item.AsDto();
        }

        [HttpPost]
        public async Task<ActionResult<OrderDto>> PostAsync(CreateOrderDto createOrderDto)
        {
            var order = new Order
            {
                Address = createOrderDto.Address,
                Quantity = createOrderDto.Quantity,
                CreatedDate = DateTimeOffset.UtcNow,
            };

            await repository.CreateAsync(order);

            //await publishEndpoint.Publish(new CatalogItemCreated(item.Id, item.Name, item.Description));

            return CreatedAtAction(nameof(GetByIdAsync), new { id = order.Id }, order);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(Guid id, UpdateOrderDto updateItemDto)
        {
            var existingOrder = await repository.GetAsync(id);

            if (existingOrder == null)
            {
                return NotFound();
            }

            existingOrder.Address = updateItemDto.Address;
            existingOrder.Quantity = updateItemDto.Quantity;

            await repository.UpdateAsync(existingOrder);

            //await publishEndpoint.Publish(new CatalogItemUpdated(existingItem.Id, existingItem.Name, existingItem.Description));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var item = await repository.GetAsync(id);

            if (item == null)
            {
                return NotFound();
            }
            await repository.RemoveAsync(item.Id);

            //await publishEndpoint.Publish(new CatalogItemDeleted(id));

            return NoContent();
        }
    }
}
