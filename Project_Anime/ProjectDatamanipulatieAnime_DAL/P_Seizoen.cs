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
    
    public partial class P_Seizoen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_Seizoen()
        {
            this.P_Adaptaties = new HashSet<P_Adaptatie>();
            this.P_Afleveringen = new HashSet<P_Aflevering>();
            this.P_Genre_lijstenAnime = new HashSet<P_Genre_lijstAnime>();
            this.P_Seizoenen = new HashSet<P_Seizoen>();
            this.P_Verschijningen = new HashSet<P_Verschijning>();
        }
    
        public int Seizoen_id { get; set; }
        public Nullable<int> Vervolg_id { get; set; }
        public int Studio_id { get; set; }
        public string Naam { get; set; }
        public Nullable<System.DateTime> Begindatum_uitzending { get; set; }
        public Nullable<System.DateTime> Einddatum_uitzending { get; set; }
        public string Omschrijving { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Adaptatie> P_Adaptaties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Aflevering> P_Afleveringen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Genre_lijstAnime> P_Genre_lijstenAnime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Seizoen> P_Seizoenen { get; set; }
        public virtual P_Seizoen P_Seizoen1 { get; set; }
        public virtual P_Studio P_Studio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Verschijning> P_Verschijningen { get; set; }
    }
}
