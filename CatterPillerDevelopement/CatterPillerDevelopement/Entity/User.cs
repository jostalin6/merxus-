using System;
using System.Collections.Generic;

namespace CatterPiller_Development.Entity
{
    public partial class User
    {      
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }     
    }
}
