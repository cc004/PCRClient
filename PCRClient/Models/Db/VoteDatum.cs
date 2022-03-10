using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class VoteDatum
    {
        public long VoteId { get; set; }
        public string VoteStartTime { get; set; } = null!;
        public string VoteEndTime { get; set; } = null!;
        public string ResultStartTime { get; set; } = null!;
        public string ResultEndTime { get; set; } = null!;
        public long StartStoryId { get; set; }
        public long ResultStoryId { get; set; }
    }
}
