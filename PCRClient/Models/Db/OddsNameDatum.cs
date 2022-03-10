using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class OddsNameDatum
    {
        public long Id { get; set; }
        public string OddsFile { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long IconType { get; set; }
        public string Description { get; set; } = null!;
    }
}
