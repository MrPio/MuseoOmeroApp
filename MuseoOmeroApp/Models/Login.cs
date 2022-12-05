using Newtonsoft.Json;

namespace MuseoOmeroApp.Models
{
    public class Login
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
