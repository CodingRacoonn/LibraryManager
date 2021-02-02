using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public class BookOrderEndpoint : IBookOrderEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public BookOrderEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<BookOrderInfoModel>> GetByUserId(int userId)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/bookorder/GetByUserId/{userId}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<BookOrderInfoModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }


        public async Task AddBookOrder(BookOrderSetupModel model)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/bookorder/addbookorder", model))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task CancelOrder(BookOrderSetupModel model)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/bookorder/CancelOrder", model))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
