using MuseoOmeroApp.Helpers;

namespace MuseoOmeroApp.Enums
{
    public class TipoBiglietto
    {
        private TipoBiglietto(string value,string icon) { Value = value; Icon = icon; }

        public string Value { get; private set; }
        public string Icon { get; private set; }

        public static TipoBiglietto MuseoAperto { get { return new TipoBiglietto("Museo aperto", IconFont.TicketConfirmation); } }
        public static TipoBiglietto Mostra { get { return new TipoBiglietto("Mostra",IconFont.Paw); } }
        public static TipoBiglietto Laboratorio { get { return new TipoBiglietto("Laboratorio",IconFont.Puzzle); } }

        public override string ToString()
        {
            return Value;
        }
    }
}
