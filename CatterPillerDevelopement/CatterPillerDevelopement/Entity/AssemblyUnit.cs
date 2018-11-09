using System;
using System.Collections.Generic;

namespace CatterPiller_Development.Entity
{
    public partial class AssemblyUnit
    {
       
        public decimal AssemblyUnitId { get; set; }
        public string Name { get; set; }
        public byte? IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    }
}
