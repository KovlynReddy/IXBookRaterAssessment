using IXBookRaterDLL.Models.DomainModel;
using IXBookRaterDLL.Models.ViewModel;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;
using System.Text;
using System.Text.Json.Serialization;
using IXBookRaterDLL.Models.Dto;

namespace IXBookRaterMVC.Services
{
    public static class BookRatingService
    {
        public static async Task<List<Book>> GetAllBookings()
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:7173");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync("api/BookRating");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = await response.Content.ReadFromJsonAsync<List<Book>>();
                    return responseObject;
                }
                else
                {
                    return null;
                }
            }
        }

        public static async Task RateBook(RateBookDto model)
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = JsonConvert.SerializeObject(model);
                var content = new StringContent(payload.ToString(), Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:7173");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.PostAsync("api/Rating", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = await response.Content.ReadFromJsonAsync<Rating>();

                }
                else
                {

                }
            }
        }

        public static async Task CreateBook(CreateBookDto model)
        {
            using (HttpClient client = new HttpClient())
            {
                var payload= JsonConvert.SerializeObject(model);
                var content = new StringContent(payload.ToString(), Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:7173");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.PostAsync("api/BookRating", content);

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
