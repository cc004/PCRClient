using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class GlobalDatum
    {
        public string KeyName { get; set; } = null!;
        public long Value { get; set; }
        public string Desc { get; set; } = null!;
    }
}
