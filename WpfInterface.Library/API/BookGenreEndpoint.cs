using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public class BookGenreEndpoint : IBookGenreEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public BookGenreEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<BookGenreModel>> GetByBookId(int bookId)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/bookgenre/GetByBookId/{bookId}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<BookGenreModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }


        public async Task AddBookGenre(BookGenreModel model)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/bookgenre/addbookgenre", model))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
