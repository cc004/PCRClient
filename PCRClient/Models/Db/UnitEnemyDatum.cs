using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitEnemyDatum
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public long PrefabId { get; set; }
        public long MotionType { get; set; }
        public long SeType { get; set; }
        public long MoveSpeed { get; set; }
        public long SearchAreaWidth { get; set; }
        public long AtkType { get; set; }
        public double NormalAtkCastTime { get; set; }
        public long Cutin { get; set; }
        public long CutinStar6 { get; set; }
        public long VisualChangeFlag { get; set; }
        public string Comment { get; set; } = null!;
    }
}
