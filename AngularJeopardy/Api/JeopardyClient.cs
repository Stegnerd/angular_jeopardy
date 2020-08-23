using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngularJeopardy.Api.Interface;
using AngularJeopardy.Models;
using AngularJeopardy.Util;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace AngularJeopardy.Api
{
    public class JeopardyClient : IJeopardyClient
    {
        private readonly IRestClient _client;

        public JeopardyClient(IConfiguration configuration, IRestClient client)
        {
            _client = client;
            _client.BaseUrl = new Uri(configuration.GetValue<string>("ApiEndpoint"));
        }
        
        public async  Task<List<Category>> GetCategoriesAsync(int count = 5, int offset = 0)
        {
            var request = new RestRequest("categories", Method.GET).AddParameter("count", count).AddParameter("offset", offset);

            var response = await _client.ExecuteAsync<List<Category>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception(Constants.GetCategoryError, response.ErrorException);
            }

            return response.Data;
        }

        public async Task<List<Question>> GetQuestionByCategoryAsync(int categoryId)
        {
            var request = new RestRequest("clues", Method.GET).AddParameter("category", categoryId);

            var response = await _client.ExecuteAsync<List<Question>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception(Constants.GetQuestionError, response.ErrorException);
            }
            
            return response.Data;
        }
    }
}