using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneDiarySetting
    {
        public long EventId { get; set; }
        public string BgmSheetName { get; set; } = null!;
        public string BgmCueName { get; set; } = null!;
    }
}
