using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SekaiTopDatum
    {
        public long Id { get; set; }
        public long SekaiId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long TopBg { get; set; }
        public long PositionX { get; set; }
        public long PositionY { get; set; }
        public double ScaleRatio { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
        public long BossMode { get; set; }
        public long SekaiBossModeId { get; set; }
        public string BossHpFrom { get; set; } = null!;
        public string BossHpTo { get; set; } = null!;
        public string BossTimeFrom { get; set; } = null!;
        public string BossTimeTo { get; set; } = null!;
        public long Duration { get; set; }
        public long StoryId { get; set; }
    }
}
