using System.Net.Http;
using System.Net.Http.Json;

namespace UAS_Frontend
{
    public class apiService
    {
        private readonly HttpClient _httpClient;

        public apiService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<List<Post>> GetPosts()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts");
            return response;
        }
        public async Task<List<Photos>> GetPhotos()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Photos>>("https://jsonplaceholder.typicode.com/photos");
            return response;
        }
        public async Task<List<Comments>> GetComments()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Comments>>("https://jsonplaceholder.typicode.com/comments");
            return response;
        }
        public async Task<List<Users>> GetUsers()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Users>>("https://jsonplaceholder.typicode.com/users");
            return response;
        }

    }
}
