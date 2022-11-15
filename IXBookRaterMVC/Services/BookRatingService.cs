using IXBookRaterDLL.Models.DomainModel;
using IXBookRaterDLL.Models.ViewModel;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;
using System.Text;
using System.Text.Json.Serialization;

namespace IXBookRaterMVC.Services
{
    public static class BookRatingService
    {
        public static async Task GetAllBookings()
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:7173");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync("api/BookRating/GetAllBooks");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = await response.Content.ReadFromJsonAsync<Rating>();

                }
                else
                {

                }
            }
        }

        public static async Task RateBook(RateBookingViewModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = JsonConvert.SerializeObject(model);
                var content = new StringContent(payload.ToString(), Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:7173");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.PostAsync("api/BookRating/RateBook", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = await response.Content.ReadFromJsonAsync<Rating>();

                }
                else
                {

                }
            }
        }

        public static async Task CreateBook(CreateBookViewModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                var payload= JsonConvert.SerializeObject(model);
                var content = new StringContent(payload.ToString(), Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:7173");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.PostAsync("api/BookRating/CreateBook", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = await response.Content.ReadFromJsonAsync<Rating>();

                }
                else
                {

                }
            }
        }

    }
}
