using MuseoOmeroApp.Enums;
using Newtonsoft.Json;

namespace MuseoOmeroApp.Models
{
    public class Biglietto
    {
        [JsonProperty("data_acquisto")]
        public DateTime DataAcquisto { get; set; }

        [JsonProperty("data_validita")]
        public DateTime DataValidita { get; set; }

        [JsonProperty("tipologia")]
        public TipoBiglietto Tipologia { get; set; }

        [JsonProperty("data_guida")]
        public DateTime? DataGuida { get; set; }

        public Biglietto(DateTime dataAcquisto, DateTime dataValidita, TipoBiglietto tipologia, DateTime? dataGuida)
        {
            DataAcquisto = dataAcquisto;
            DataValidita = dataValidita;
            Tipologia = tipologia;
            DataGuida = dataGuida;
        }
    }
}
