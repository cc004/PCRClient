using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ArcadeStoryList
    {
        public long StoryId { get; set; }
        public long ArcadeId { get; set; }
        public string SubTitle { get; set; } = null!;
    }
}
