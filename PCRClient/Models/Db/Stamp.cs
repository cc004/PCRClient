using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class Stamp
    {
        public long StampId { get; set; }
        public long DispOrder { get; set; }
        public string Description { get; set; } = null!;
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
    }
}
