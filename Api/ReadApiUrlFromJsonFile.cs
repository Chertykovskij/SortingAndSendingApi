using System.Text.Json;
using System.IO;


namespace SortingAndSendingApi.Api
{
    public class ReadApiUrlFromJsonFile : IReadApiUrlFromConfigFile
    {
        public string ReadApiUrl(string filePath)
        {
            string _filePath = filePath;
            string apiUrl;

            // Чтение содержимого файла
            string json = File.ReadAllText(_filePath);

            // Десериализация JSON
            var config = JsonSerializer.Deserialize<Config>(json);

            // Получение URL из конфигурации
            apiUrl = config.ApiUrl;

            return apiUrl;
        }
    }
}
