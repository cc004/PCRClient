using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitComment
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long UseType { get; set; }
        public long VoiceId { get; set; }
        public long FaceId { get; set; }
        public double ChangeTime { get; set; }
        public long ChangeFace { get; set; }
        public string Description { get; set; } = null!;
    }
}
