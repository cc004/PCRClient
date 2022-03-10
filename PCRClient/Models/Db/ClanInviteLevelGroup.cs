using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanInviteLevelGroup
    {
        public long LevelGroupId { get; set; }
        public long TeamLevelFrom { get; set; }
        public long TeamLevelTo { get; set; }
    }
}
