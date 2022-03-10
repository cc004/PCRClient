using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SekaiTopStoryDatum
    {
        public long SekaiId { get; set; }
        public long StoryId { get; set; }
        public string BossTimeFrom { get; set; } = null!;
        public string BossTimeTo { get; set; } = null!;
    }
}
