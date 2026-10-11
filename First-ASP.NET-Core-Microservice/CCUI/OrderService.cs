using CCUI.Infrastructure;
namespace CCUI
{
    public class OrderService
    {
        private readonly HttpClient _http;
        public OrderService(HttpClient http) => _http = http;

        public Task<List<OrderDto>?> GetAllAsync() =>
            _http.GetFromJsonAsync<List<OrderDto>>("order");

        public Task<OrderDto?> GetByIdAsync(Guid id) =>
            _http.GetFromJsonAsync<OrderDto>($"order/{id}");

        public async Task<OrderDto?> CreateAsync(CreateOrderDto dto)
        {
            var response = await _http.PostAsJsonAsync("order", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<OrderDto>();
        }

        public async Task UpdateAsync(Guid id, UpdateOrderDto dto)
        {
            var response = await _http.PutAsJsonAsync($"order/{id}", dto);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(Guid id)
        {
            var response = await _http.DeleteAsync($"order/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
