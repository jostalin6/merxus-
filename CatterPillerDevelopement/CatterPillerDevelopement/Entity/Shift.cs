using System;
using System.Collections.Generic;

namespace CatterPiller_Development.Entity
{
    public partial class Shift
    {

        public decimal ShiftId { get; set; }
        public string Name { get; set; }
        public decimal Hours { get; set; }
        public TimeSpan ShiftFrom { get; set; }
        public TimeSpan ShiftTo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
       
    }
}
