using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitDatum
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public string Kana { get; set; } = null!;
        public long PrefabId { get; set; }
        public long PrefabIdBattle { get; set; }
        public long IsLimited { get; set; }
        public long Rarity { get; set; }
        public long MotionType { get; set; }
        public long SeType { get; set; }
        public long MoveSpeed { get; set; }
        public long SearchAreaWidth { get; set; }
        public long AtkType { get; set; }
        public double NormalAtkCastTime { get; set; }
        public long Cutin1 { get; set; }
        public long Cutin2 { get; set; }
        public long Cutin1Star6 { get; set; }
        public long Cutin2Star6 { get; set; }
        public long GuildId { get; set; }
        public long ExskillDisplay { get; set; }
        public string Comment { get; set; } = null!;
        public long OnlyDispOwned { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
