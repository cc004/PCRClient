using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SpaceBattleDatum
    {
        public long SpaceBattleId { get; set; }
        public long SpaceEnemyId { get; set; }
        public long LimitTime { get; set; }
        public long ClearRewardGroup { get; set; }
        public long Background { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
        public long ResultBossPositionY { get; set; }
        public long QuestDetailBgId { get; set; }
        public long QuestDetailBgPosition { get; set; }
        public string QuestName { get; set; } = null!;
    }
}
