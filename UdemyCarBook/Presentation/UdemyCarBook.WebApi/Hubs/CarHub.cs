using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using UdemyCarBook.WebApi.Models;

namespace UdemyCarBook.WebApi.Hubs
{
    public class CarHub : Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCarCount()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarCount");
            var value = await responseMessage.Content.ReadAsStringAsync();
            var carCount = JsonConvert.DeserializeObject<CarCountModel>(value).CarCount.ToString();

            await Clients.All.SendAsync("ReceiveCarCount", carCount);
        }
    }
}
