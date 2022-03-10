using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class Movie
    {
        public long MovieId { get; set; }
        public long StoryGroupId { get; set; }
        public long StoryId { get; set; }
        public string BgmId { get; set; } = null!;
        public string SeId { get; set; } = null!;
        public long MyPageFlag { get; set; }
        public long FadeLoopFlag { get; set; }
        public double BgmVolumeRate { get; set; }
    }
}
