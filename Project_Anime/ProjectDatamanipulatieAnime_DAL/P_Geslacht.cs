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
    
    public partial class P_Geslacht
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_Geslacht()
        {
            this.P_Auteurs = new HashSet<P_Auteur>();
            this.P_Personages = new HashSet<P_Personage>();
            this.P_Stemacteurs = new HashSet<P_Stemacteur>();
        }
    
        public int Geslacht_id { get; set; }
        public string Naam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Auteur> P_Auteurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Personage> P_Personages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Stemacteur> P_Stemacteurs { get; set; }
    }
}
