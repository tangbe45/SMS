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
        public async Task<List<LevelDto>> GetClasses()
        {
            var classes = await _client.GetFromJsonAsync<LevelDto[]>("classes");
            //var content = await response.Content.ReadAsStringAsync();

            //if(!response.IsSuccessStatusCode)
            //{
            //    throw new ApplicationException(content);
            //}

            //var classes =  JsonSerializer.Deserialize<IEnumerable<LevelDto>>(content, _options);
            //return classes ??= new List<LevelDto>();
            return classes.ToList();
        }

        public async Task<LevelDto> Create(LevelDto levelDto)
        {
            var result = await _client.PostAsJsonAsync<LevelDto>("classes", levelDto);
            result.EnsureSuccessStatusCode();

            var content = await result.Content.ReadAsStringAsync();
            var level = JsonSerializer.Deserialize<LevelDto>(content);

            return level;

        }

        public async Task Modify(int id, LevelDto levelDto)
        {
            var result = await _client.PutAsJsonAsync($"classes/{id}", levelDto);
            result.EnsureSuccessStatusCode();
        }

        public async Task<LevelDto> getClass(int id)
        {
            var level = await _client.GetFromJsonAsync<LevelDto>($"classes/{id}");
            return level;
        }
    }
}
