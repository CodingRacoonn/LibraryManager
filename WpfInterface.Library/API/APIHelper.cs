﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public class APIHelper : IAPIHelper
    {

        private HttpClient _apiClient;
        private ILoggedUserModel _loggedUser;
        private readonly IConfiguration _config;

        public APIHelper(ILoggedUserModel loggedUser, IConfiguration config)
        {
            _loggedUser = loggedUser;
            _config = config;
            InitializeClient();
        }


        public HttpClient ApiClient
        {
            get
            {
                return _apiClient;
            }
        }

        private void InitializeClient()
        {
            string api = _config.GetValue<string>("api");

            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type","password"),
                new KeyValuePair<string, string>("username",username),
                new KeyValuePair<string, string>("password",password),
            });

            using (HttpResponseMessage response = await _apiClient.PostAsync("api/token/create", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public void LogOffUser()
        {
            _apiClient.DefaultRequestHeaders.Clear();
        }


        public async Task GetLoggedInUserInfo(string token)
        {
            _apiClient.DefaultRequestHeaders.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            using (HttpResponseMessage response = await _apiClient.GetAsync("/api/User"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<LoggedUserModel>();
                    _loggedUser.CreatedDate = result.CreatedDate;
                    _loggedUser.EmailAddress = result.EmailAddress;
                    _loggedUser.FirstName = result.FirstName;
                    _loggedUser.Id = result.Id;
                    _loggedUser.LastName = result.LastName;
                    _loggedUser.Token = token;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
