using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneSpecialBossTicketCount
    {
        public long Id { get; set; }
        public long ChallengeCountFrom { get; set; }
        public long ChallengeCountTo { get; set; }
        public long UseTicketNum { get; set; }
    }
}
