using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json.Linq;
namespace http
{
    class Httpgetpost
    {
        public async Task<string> GetAsync<T>()
        {
            HttpClient httpobj = new HttpClient();
            string type = typeof(T).Name;
            string url = "http://ggku2ser2/api/values/get" + type + "s";
            HttpResponseMessage response = await httpobj.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();
            return (result);
        }
        public async Task<string> PostAsync<T>(object obj)
        {

            string type = typeof(T).Name;
            string url = "http://ggku2ser2/api/values/Add" + type;
            HttpClient client = new HttpClient();
            StringContent sc = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(obj), UnicodeEncoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, sc);
            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Result: " + content);
            return content;
        }
    }

}