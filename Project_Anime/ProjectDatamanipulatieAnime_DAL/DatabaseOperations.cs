using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectDatamanipulatieAnime_DAL
{
    public static class DatabaseOperations
    {
        public static List<P_Seizoen> OphalenSeizoenen()
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Seizoen
                    .Include("P_Studio");
                return query.ToList();
            }
        }
        public static List<P_Seizoen> OphalenSeizoenviaID(int seizoenID)
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Seizoen
                    .Where(x => x.Seizoen_id == seizoenID)
                    .Include("P_Studio")
                    .Include("P_Seizoenen")
                    .Include("P_Seizoen1")
                    .Include(x => x.P_Adaptaties.Select(sub => sub.P_Manga));
                return query.ToList();
            }
        }

        public static List<P_Aflevering> OphalenAfleveringenviaSeizoenID(int seizoenID)
        {
            using (AnimeModel entities = new AnimeModel())
            {
                var query = entities.P_Aflevering
                    .Where(x => x.Seizoen_id == seizoenID)
                    .OrderBy(x => x.Aflevering_id);
                return query.ToList();
            }
        }
        public static List<P_Personage> OphalenPersonagesviaSeizoenID(int seizoenID)
        {
            using (AnimeModel VerschijningEntities = new AnimeModel())
            {
                List<P_Personage> query = new List<P_Personage>();

                var verschijningquery = VerschijningEntities.P_Verschijning
                    .Where(x => x.Seizoen_id == seizoenID);
                foreach (P_Verschijning VerschijningPersonage in verschijningquery)
                {
                    using (AnimeModel entities = new AnimeModel())
                    {
                        var querypart = entities.P_Personage
                            .Where(x => x.Personage_id == VerschijningPersonage.Personage_id)
                            .Include("P_Geslacht");
                        query.AddRange(querypart);
                    }
                }
                return query;
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
        public static List<P_Manga> OphalenMangaNamen()
        {
            using (AnimeModel entities = new AnimeModel())
            {
                return entities.P_Manga
                    .OrderBy(x=> x.Naam)
                    .ToList();
            }
        }
        public static List<P_Manga> OphalenMangaviaMangaID(int mangaID)
        {
            using (AnimeModel entities = new AnimeModel())
            {
                return entities.P_Manga
                    .Where(x => x.Manga_id == mangaID)
                    .OrderBy(x => x.Naam)
                    .Include("P_Auteur")
                    .Include(x => x.P_Genre_Lijsten_Manga.Select(sub => sub.P_Genre))
                    .ToList();
            }
        }
    }
}
