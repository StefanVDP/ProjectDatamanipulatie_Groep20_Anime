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
    
    public partial class P_Stemacteur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_Stemacteur()
        {
            this.P_Personages = new HashSet<P_Personage>();
        }
    
        public int Stemacteur_id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public Nullable<System.DateTime> Geboortedatum { get; set; }
        public Nullable<int> Geslacht_id { get; set; }
    
        public virtual P_Geslacht P_Geslacht { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Personage> P_Personages { get; set; }
    }
}
