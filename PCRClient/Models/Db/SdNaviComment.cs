using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SdNaviComment
    {
        public long CommentId { get; set; }
        public long WhereType { get; set; }
        public long CharacterId { get; set; }
        public long MotionType { get; set; }
        public string? Description { get; set; }
        public long VoiceId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
