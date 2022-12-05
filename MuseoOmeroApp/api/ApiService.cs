using MuseoOmeroApp.Enums;
using MuseoOmeroApp.Models;
using MuseoOmeroApp.ViewModel.Templates;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MuseoOmeroApp.api
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

        public async Task<IEnumerable<BigliettoViewModel>> LoadBiglietti(DateTime data=default)
        {
            var dataScelta=data==default?DateTime.Today:data;
            //TODO
            await Task.Delay(1000);
            var biglietti= new List<Biglietto>()
            {
                new Biglietto(
                    dataAcquisto:DateTime.ParseExact("10/10/2010","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    dataValidita:DateTime.Today,
                    tipologia:TipoBiglietto.MuseoAperto,
                    dataGuida:null
                    ),
                new Biglietto(
                    dataAcquisto:DateTime.ParseExact("10/10/2010","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    dataValidita:DateTime.ParseExact("10/12/2022","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    tipologia:TipoBiglietto.Mostra,
                    dataGuida:DateTime.Now
                    ),
            };
            return from biglietto in biglietti select new BigliettoViewModel(biglietto);
            
        }

    }
}
