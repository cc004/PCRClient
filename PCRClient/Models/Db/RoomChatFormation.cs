using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomChatFormation
    {
        public long Id { get; set; }
        public long Unit1X { get; set; }
        public long Unit1Y { get; set; }
        public long Unit1Dir { get; set; }
        public long Unit2X { get; set; }
        public long Unit2Y { get; set; }
        public long Unit2Dir { get; set; }
        public long? Unit3X { get; set; }
        public long? Unit3Y { get; set; }
        public long? Unit3Dir { get; set; }
        public long? Unit4X { get; set; }
        public long? Unit4Y { get; set; }
        public long? Unit4Dir { get; set; }
        public long? Unit5X { get; set; }
        public long? Unit5Y { get; set; }
        public long? Unit5Dir { get; set; }
        public long UnitNum { get; set; }
        public long? UnitId1 { get; set; }
        public long? UnitId2 { get; set; }
        public long? UnitId3 { get; set; }
        public long? UnitId4 { get; set; }
        public long? UnitId5 { get; set; }
        public long? IgnoreUnitId1 { get; set; }
        public long? IgnoreUnitId2 { get; set; }
        public long? IgnoreUnitId3 { get; set; }
        public long? IgnoreUnitId4 { get; set; }
        public long? IgnoreUnitId5 { get; set; }
    }
}
