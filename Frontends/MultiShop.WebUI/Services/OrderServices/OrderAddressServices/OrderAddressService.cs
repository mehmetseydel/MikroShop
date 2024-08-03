using MultiShop.DtoLayer.DiscountDtos;
using MultiShop.DtoLayer.OrderDtos.OrderAddressDtos;
using System.Net.Http;

namespace MultiShop.WebUI.Services.OrderServices.OrderAddressServices
{
    public class OrderAddressService : IOrderAddressService
    {
        private readonly HttpClient _httpClient;
        public OrderAddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateOrderAddressAsync(CreateOrderAddressDto createOrderAddressDto)
        {
            await _httpClient.PostAsJsonAsync<CreateOrderAddressDto>("addresses", createOrderAddressDto); //cretae aynı işlem 
        }
    }
}


