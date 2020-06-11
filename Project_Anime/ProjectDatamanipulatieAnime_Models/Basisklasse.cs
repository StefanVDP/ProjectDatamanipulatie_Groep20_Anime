using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDatamanipulatieAnime_Models
{
    public abstract class Basisklasse
    {
        public abstract string Valideer(string propertynaam);

        public bool IsGeldig()
        {
            return string.IsNullOrWhiteSpace(Foutmeldingen);

        }
        public string Foutmeldingen
        {
            get
            {
                string foutmeldingen = "";

                foreach (var item in this.GetType().GetProperties()) //reflection 
                {
                    if (item.CanRead)
                    {
                        string fout = Valideer(item.Name);
                        if (!string.IsNullOrWhiteSpace(fout))
                        {
                            foutmeldingen += fout + Environment.NewLine;
                        }
                    }
                }
                return foutmeldingen;
            }
        }

    }
}
