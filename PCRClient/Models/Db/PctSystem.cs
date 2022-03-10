using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class PctSystem
    {
        public long Id { get; set; }
        public long PctBaseSpeed { get; set; }
        public long FeverPointMax { get; set; }
        public long FeverTime { get; set; }
        public long FeverReventionTime { get; set; }
        public long PctTime { get; set; }
        public long Chara1 { get; set; }
        public long Chara2 { get; set; }
        public long Chara1GaugeChoice { get; set; }
        public long Chara2GaugeChoice { get; set; }
    }
}
