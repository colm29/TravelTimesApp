//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelTimesApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TravelTime
    {
        public int ID { get; set; }
        public Nullable<int> Origin_Movement_ID { get; set; }
        public string Origin_Display_Name { get; set; }
        public Nullable<int> Destination_Movement_ID { get; set; }
        public string Destination_Display_Name { get; set; }
        public string Date_Range { get; set; }
        public Nullable<int> Mean_Travel_Time__Seconds_ { get; set; }
        public Nullable<int> Range___Lower_Bound_Travel_Time__Seconds_ { get; set; }
        public Nullable<int> Range___Upper_Bound_Travel_Time__Seconds_ { get; set; }
    }
}