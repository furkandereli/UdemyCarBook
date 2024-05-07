using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AuthorDtos;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region CarCount
            var responseMessage = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int CarCountRandom = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCount = values.CarCount;
                ViewBag.CarCountRandom = CarCountRandom;
            }
            #endregion

            #region LocationCount
            var responseMessage2 = await client.GetAsync("https://localhost:7236/api/Statictics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int LocationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.LocationCount = values2.LocationCount;
                ViewBag.LocationCountRandom = LocationCountRandom;
            }
            #endregion

            #region AuthorCount
            var responseMessage3 = await client.GetAsync("https://localhost:7236/api/Statictics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int AuthorCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.AuthorCount = values3.AuthorCount;
                ViewBag.AuthorCountRandom = AuthorCountRandom;
            }
            #endregion

            #region BlogCount
            var responseMessage4 = await client.GetAsync("https://localhost:7236/api/Statictics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int BlogCountRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.BlogCount = values4.BlogCount;
                ViewBag.BlogCountRandom = BlogCountRandom;
            }
            #endregion

            #region BrandCount
            var responseMessage5 = await client.GetAsync("https://localhost:7236/api/Statictics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int BrandCountRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.BrandCount = values5.BrandCount;
                ViewBag.BrandCountRandom = BrandCountRandom;
            }
            #endregion

            #region GetAvgRentPriceForDaily
            var responseMessage6 = await client.GetAsync("https://localhost:7236/api/Statictics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int AvgRentPriceForDailyRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.AvgRentPriceForDaily = values6.AvgPriceForDaily.ToString("0.00");
                ViewBag.AvgRentPriceForDailyRandom = AvgRentPriceForDailyRandom;
            }
            #endregion

            #region GetAvgRentPriceForWeekly
            var responseMessage7 = await client.GetAsync("https://localhost:7236/api/Statictics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int AvgRentPriceForWeeklyRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.AvgRentPriceForWeekly = values7.AvgPriceForWeekly.ToString("0.00");
                ViewBag.AvgRentPriceForWeeklyRandom = AvgRentPriceForWeeklyRandom;
            }
            #endregion

            #region GetAvgRentPriceForMonthly
            var responseMessage8 = await client.GetAsync("https://localhost:7236/api/Statictics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int AvgRentPriceForMonthlyRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.AvgRentPriceForMonthly = values8.AvgPriceForMonthly.ToString("0.00");
                ViewBag.AvgRentPriceForMonthlyRandom = AvgRentPriceForMonthlyRandom;
            }
            #endregion

            #region GetCarCountByTransmissionAuto
            var responseMessage9 = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarCountByTransmissionAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int CarCountByTransmissionAutoRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.CarCountByTransmissionAuto = values9.CarCountByTransmissionAuto;
                ViewBag.CarCountByTransmissionAutoRandom = CarCountByTransmissionAutoRandom;
            }
            #endregion

            #region GetBrandNameByMaxCar
            var responseMessage10 = await client.GetAsync("https://localhost:7236/api/Statictics/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int BrandNameByMaxCarRandom = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.BrandNameByMaxCar = values10.BrandNameByMaxCar;
                ViewBag.BrandNameByMaxCarRandom = BrandNameByMaxCarRandom;
            }
            #endregion

            #region GetBlogTitleByMaxBlogComment
            var responseMessage11 = await client.GetAsync("https://localhost:7236/api/Statictics/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int BlogTitleByMaxBlogCommentRandom = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.BlogTitleByMaxBlogComment = values11.BlogTitleByMaxBlogComment;
                ViewBag.BlogTitleByMaxBlogCommentRandom = BlogTitleByMaxBlogCommentRandom;
            }
            #endregion

            #region GetCarCountByKmLessThen1000
            var responseMessage12 = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarCountByKmLessThen1000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int CarCountByKmLessThen1000Random = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.CarCountByKmLessThen1000 = values12.CarCountByKmLessThen1000;
                ViewBag.CarCountByKmLessThen1000Random = CarCountByKmLessThen1000Random;
            }
            #endregion

            #region GetCarCountByFuelGasolineOrDiesel
            var responseMessage13 = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int CarCountByFuelGasolineOrDieselRandom = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.CarCountByFuelGasolineOrDiesel = values13.CarCountByFuelGasolineOrDiesel;
                ViewBag.CarCountByFuelGasolineOrDieselRandom = CarCountByFuelGasolineOrDieselRandom;
            }
            #endregion

            #region GetCarCountByFuelElectric
            var responseMessage14 = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int CarCountByFuelElectricRandom = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.CarCountByFuelElectric = values14.CarCountByFuelElectric;
                ViewBag.CarCountByFuelElectricRandom = CarCountByFuelElectricRandom;
            }
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMax
            var responseMessage15 = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int CarBrandAndModelByRentPriceDailyMaxRandom = random.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.CarBrandAndModelByRentPriceDailyMax = values15.CarBrandAndModelByRentPriceDailyMax;
                ViewBag.CarBrandAndModelByRentPriceDailyMaxRandom = CarBrandAndModelByRentPriceDailyMaxRandom;
            }
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMin
            var responseMessage16 = await client.GetAsync("https://localhost:7236/api/Statictics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int CarBrandAndModelByRentPriceDailyMinRandom = random.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.CarBrandAndModelByRentPriceDailyMin = values16.CarBrandAndModelByRentPriceDailyMin;
                ViewBag.CarBrandAndModelByRentPriceDailyMinRandom = CarBrandAndModelByRentPriceDailyMinRandom;
            }
            #endregion

            return View();
        }
    }
}