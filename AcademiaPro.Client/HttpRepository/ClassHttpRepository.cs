using AcademiaPro.Client.HttpRepository.Contracts;
using AcademiaPro.Contracts.Classes;
using System.Net.Http.Json;
using System.Text.Json;

namespace AcademiaPro.Client.HttpRepository
{
    public class ClassHttpRepository : IClassHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public ClassHttpRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
        }
        public async Task<List<ListLevelDto>> GetClasses()
        {
            var classes = await _client.GetFromJsonAsync<ListLevelDto[]>("classes");
            //var content = await response.Content.ReadAsStringAsync();

            //if(!response.IsSuccessStatusCode)
            //{
            //    throw new ApplicationException(content);
            //}

            //var classes =  JsonSerializer.Deserialize<IEnumerable<LevelDto>>(content, _options);
            //return classes ??= new List<LevelDto>();
            return classes.ToList();
        }

        public async Task<ListLevelDto> Create(ListLevelDto levelDto)
        {
            var result = await _client.PostAsJsonAsync<ListLevelDto>("classes", levelDto);
            result.EnsureSuccessStatusCode();

            var content = await result.Content.ReadAsStringAsync();
            var level = JsonSerializer.Deserialize<ListLevelDto>(content);

            return level;

        }

        public async Task Modify(int id, ListLevelDto levelDto)
        {
            var result = await _client.PutAsJsonAsync($"classes/{id}", levelDto);
            result.EnsureSuccessStatusCode();
        }

        public async Task<ListLevelDto> getClass(int id)
        {
            var level = await _client.GetFromJsonAsync<ListLevelDto>($"classes/{id}");
            return level;
        }

        public async Task Delete(int id)
        {
            var result = await _client.DeleteAsync($"classes/{id}");
            result.EnsureSuccessStatusCode(); 
        }
    }
}
