using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomChatScenario
    {
        public long Id { get; set; }
        public long ScenarioIdx { get; set; }
        public long UnitPosNo { get; set; }
        public long Delay { get; set; }
        public long AffectType { get; set; }
        public long AnimeId { get; set; }
        public long IconId { get; set; }
    }
}
