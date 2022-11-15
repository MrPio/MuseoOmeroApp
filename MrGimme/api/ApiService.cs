using MrGimme.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MrGimme.api
{
    public class ApiService
    {
        public static readonly string root = "http://192.168.1.5:80/";
        //public static readonly string rootLocalHost = "http://localhost:80/";
        //public static readonly string rootWlan = "http://192.168.1.5:80/";
        //public static readonly string rootRemote = "http://80.181.159.88:80/";

        private static async Task<HttpResponseMessage> Post(string endpoint,object body)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                return await httpClient.PostAsync(root + endpoint, content);
            }
            catch (Exception e) {
                Console.WriteLine(e);   
                return null;
            }
        }

        public async Task<Login> Login(string username, string password)
        {
            var login = new Login()
            {
                Username = username,
                Password = password
            };

            var response= await Post("login", login);
            if (response is null || !response.IsSuccessStatusCode)
                return null;

            return JsonConvert.DeserializeObject<Login>(await response.Content.ReadAsStringAsync());
        }

    }
}
