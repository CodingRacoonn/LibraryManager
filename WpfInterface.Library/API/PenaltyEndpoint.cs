using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public class PenaltyEndpoint : IPenaltyEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public PenaltyEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<PenaltyInfoModel>> GetByUserId(int userId)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/penalty/GetByUserId/{userId}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<PenaltyInfoModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task AddPenalty(PenaltyModel model)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/penalty/AddPenalty", model))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
