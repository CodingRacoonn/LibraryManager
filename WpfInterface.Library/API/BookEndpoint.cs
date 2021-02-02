using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public class BookEndpoint : IBookEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public BookEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }


        public async Task<List<BookModel>> GetAllBooks()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/book/getallbooks"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<BookModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<AuthorModel>> GetAllAuthors()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/book/getallauthors"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<AuthorModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<BookModel>> GetByTitle(string bookTitle)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/book/getbytitle/{bookTitle}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<BookModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }


        public async Task<List<BookModel>> GetByPublisher(string bookPublisher)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/book/getbypublisher/{bookPublisher}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<BookModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }


        public async Task<List<BookModel>> GetByAuthor(string authorFN, string authorLN)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/book/getbypublisher/{authorFN}/{authorLN}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<BookModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }


        public async Task AddBook(BookModel model)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/book/addbook", model))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
