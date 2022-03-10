using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomEmotionIcon
    {
        public long Id { get; set; }
        public long EnableAuto { get; set; }
        public long EnableTap { get; set; }
    }
}
