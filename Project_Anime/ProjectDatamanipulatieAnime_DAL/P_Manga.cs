//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectDatamanipulatieAnime_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class P_Manga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_Manga()
        {
            this.P_Adaptaties = new HashSet<P_Adaptatie>();
            this.P_Genre_Lijsten_Manga = new HashSet<P_Genre_Lijst_Manga>();
        }
    
        public int Manga_id { get; set; }
        public int Auteur_id { get; set; }
        public string Naam { get; set; }
        public Nullable<System.DateTime> StartPublishdatum { get; set; }
        public Nullable<System.DateTime> EindePublishDatum { get; set; }
        public string Omschrijving { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Adaptatie> P_Adaptaties { get; set; }
        public virtual P_Auteur P_Auteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Genre_Lijst_Manga> P_Genre_Lijsten_Manga { get; set; }
    }
}
