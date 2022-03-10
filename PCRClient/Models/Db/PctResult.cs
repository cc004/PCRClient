using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class PctResult
    {
        public long Id { get; set; }
        public long CharacterId { get; set; }
        public long ScoreFrom { get; set; }
        public long ScoreTo { get; set; }
        public long CommentId1 { get; set; }
        public long CommentId2 { get; set; }
        public long CommentId3 { get; set; }
        public long CommentId4 { get; set; }
        public long CommentId5 { get; set; }
    }
}
