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
    
    public partial class P_Aflevering
    {
        public int Aflevering_id { get; set; }
        public int Seizoen_id { get; set; }
        public string Naam { get; set; }
        public Nullable<System.DateTime> Airdatum { get; set; }
        public Nullable<System.TimeSpan> Speelduur { get; set; }
        public string Omschrijving { get; set; }
    
        public virtual P_Seizoen P_Seizoen { get; set; }
    }
}
