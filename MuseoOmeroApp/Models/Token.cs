using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.Models
{
    public class Token
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

    }
}
