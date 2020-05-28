using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDatamanipulatieAnime_Models
{
    public abstract class Projectlid : Basisklasse
    {
        //attributen, kenmerken
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Woonplaats { get; set; }
        //constructor
        public Projectlid(string naam, string voornaam, string woonplaats)
        {
            this.Naam = naam;
            this.Voornaam = voornaam;
            this.Woonplaats = woonplaats;
        }

        public override string ToString()
        {
            return Naam + " " + Voornaam + " van " + Woonplaats + ".";
        }

        public override string Valideer(string propertynaam)
        {
            if (propertynaam == "")
            {
                return "De gegevens van dit projectlid zijn onvolledig!";
            }

            return "";
        }

    }
}
