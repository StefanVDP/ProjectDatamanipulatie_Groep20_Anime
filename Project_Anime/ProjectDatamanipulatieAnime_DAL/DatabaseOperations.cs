using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDatamanipulatieAnime_DAL
{
    public static class DatabaseOperations
    {
        public static List<P_Seizoen> OphalenSeizoenen()
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Seizoen;
                return query.ToList();
            }
        }
        public static List<P_Aflevering> OphalenAfleveringen()
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Aflevering;
                return query.ToList();
            }
        }
        public static List<P_Genre> OphalenGenres()
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Genre;
                return query.ToList();
            }
        }
        public static List<P_Manga> OphalenMangas()
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Manga;
                return query.ToList();
            }
        }
        public static List<P_Personage> OphalenPersonages()
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Personage;
                return query.ToList();
            }
        }
    }
}
