using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDatamanipulatieAnime_Models
{
    public class ProjectlidVenster : Projectlid
    {
        public string NaamVenster { get; set; }

        public ProjectlidVenster(string naam, string voornaam, string woonplaats, string naamvenster)
            : base(naam, voornaam, woonplaats)
        {
            NaamVenster = naamvenster;
        }
        public override string ToString()
        {
            return NaamVenster + " was gemaakt door " + Naam + " " + Voornaam + " van " + Woonplaats + ".";
        }
    }
}
