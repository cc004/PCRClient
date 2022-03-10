using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SpecialStoryBanner
    {
        public long Id { get; set; }
        public long StoryGroupId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
