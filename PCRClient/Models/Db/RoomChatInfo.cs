using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomChatInfo
    {
        public long Id { get; set; }
        public long FormationId { get; set; }
        public long ScenarioId { get; set; }
    }
}
