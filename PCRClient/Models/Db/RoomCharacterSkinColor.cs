using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomCharacterSkinColor
    {
        public long CharacterId { get; set; }
        public long SkinColorId { get; set; }
    }
}
