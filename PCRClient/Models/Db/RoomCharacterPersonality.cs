using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomCharacterPersonality
    {
        public long CharacterId { get; set; }
        public long PersonalityId { get; set; }
    }
}
