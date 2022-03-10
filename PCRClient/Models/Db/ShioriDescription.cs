using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ShioriDescription
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public string Description { get; set; } = null!;
    }
}
