using SortingAndSendingApi.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSendingApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<int> numbers = GenerateRandomNumbers();

            Console.WriteLine("Сгенерированная последовательность:");
            PrintNumbers(numbers);

            ISortingInt sortiq = CreatorRandomSorting.CreatSorting();
            sortiq.Sort(numbers);

            Console.WriteLine("Отсортированная последовательность:");
            PrintNumbers(numbers);

            // Отправка данных на REST API сервер
            IReadApiUrlFromConfigFile readApi = new ReadApiUrlFromJsonFile();
            string apiUrl = readApi.ReadApiUrl("config.json");

            await SendDataToApi.Send(numbers, apiUrl);

            Console.WriteLine("Данные отправлены на REST API сервер.");

            Console.ReadLine();
        }

        // Генерация случайного количества чисел 
        static List<int> GenerateRandomNumbers()
        {
            var random = new Random();
            int count = random.Next(20, 101);
            var numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(-100, 101));
            }

            return numbers;
        }

        static void PrintNumbers(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        
    }
}
