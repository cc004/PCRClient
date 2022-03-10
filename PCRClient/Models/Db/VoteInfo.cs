using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class VoteInfo
    {
        public long VoteId { get; set; }
        public long VoteHelpIndex { get; set; }
        public string VoteTitle { get; set; } = null!;
        public string VoteHelp { get; set; } = null!;
    }
}
