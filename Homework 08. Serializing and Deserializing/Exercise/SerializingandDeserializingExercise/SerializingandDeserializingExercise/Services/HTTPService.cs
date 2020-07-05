using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SerializingandDeserializingExercise.Services
{
    public class HTTPService
    {
        public static string GetData(string url)
        {
            using (HttpClient _client = new HttpClient())
            {
                HttpResponseMessage response = _client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    return responseString;
                }
                else
                {
                    return $"Request failed! Message: {response.RequestMessage}, Status Code: {response.StatusCode}";
                }
            }
        }
    }
}
