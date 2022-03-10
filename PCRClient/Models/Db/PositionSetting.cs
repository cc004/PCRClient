using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class PositionSetting
    {
        public long PositionSettingId { get; set; }
        public long Front { get; set; }
        public long Middle { get; set; }
    }
}
