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
    
    public partial class P_Studio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_Studio()
        {
            this.P_Seizoen = new HashSet<P_Seizoen>();
        }
    
        public int Studio_id { get; set; }
        public string Naam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Seizoen> P_Seizoen { get; set; }
    }
}
