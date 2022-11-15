using IXBookRaterDLL.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Services
{
    public static class RateBookingService
    {

        public static async Task GetAllBooks()
        {
            using (HttpClient client = new HttpClient())
            {

            client.BaseAddress = new Uri("http://localhost:54130");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(newMediaTypeWithQualityHeaderValue("application/json"));
            //GET Method
            HttpResponseMessage response = await client.GetAsync("api/BookRatin/GetAllBooks");

            if (response.IsSuccessStatusCode)
            {
                var responseObject = await response.Content.ReadFromJsonAsync<Rating>();
               
            }
            else
            {
              
            }
            }
        }

        private static MediaTypeWithQualityHeaderValue newMediaTypeWithQualityHeaderValue(string v)
        {
            throw new NotImplementedException();
        }
    }
}
