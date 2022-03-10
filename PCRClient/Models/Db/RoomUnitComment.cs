using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomUnitComment
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long Trigger { get; set; }
        public long VoiceId { get; set; }
        public long BelovedStep { get; set; }
        public long Time { get; set; }
        public long FaceId { get; set; }
        public string Description { get; set; } = null!;
        public long InsertWordType { get; set; }
    }
}
