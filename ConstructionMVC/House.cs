//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConstructionMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class House
    {
        public int Location_HouseID { get; set; }
        public string Rooms { get; set; }
        public string Floors { get; set; }
        public Nullable<System.DateTime> BuildDate { get; set; }
        public string IsGarage { get; set; }
        public Nullable<int> CustomerID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Location Location { get; set; }
        public virtual Type Type { get; set; }
        public virtual Location Location1 { get; set; }
        public virtual Type Type1 { get; set; }
    }
}
