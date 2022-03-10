using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class Still
    {
        public long StillId { get; set; }
        public long StoryGroupId { get; set; }
        public long StoryId { get; set; }
        public long StillGroupId { get; set; }
        public long VerticalStillFlg { get; set; }
        public long PositionY { get; set; }
        public long UnitId1 { get; set; }
        public long UnitId2 { get; set; }
        public long UnitId3 { get; set; }
        public long UnitId4 { get; set; }
        public long UnitId5 { get; set; }
        public long UnitId6 { get; set; }
        public long UnitId7 { get; set; }
        public long UnitId8 { get; set; }
        public long UnitId9 { get; set; }
        public long UnitId10 { get; set; }
        public long FacialId { get; set; }
        public long AlbumIgnore { get; set; }
        public long MyPageFlag { get; set; }
        public long ScrollDirection { get; set; }
    }
}
