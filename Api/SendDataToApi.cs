using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSendingApi.Api
{
    public class SendDataToApi
    {
        /// <summary>
        /// Отправка данных на REST API сервер
        /// </summary>
        public static async Task Send(List<int> numbers, string apiUrl)
        {            
            using (HttpClient client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("numbers", string.Join(",", numbers))
                });

                await client.PostAsync(apiUrl, content);
            }
        }
    }
}
