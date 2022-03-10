using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TtkStory
    {
        public long TtkStoryId { get; set; }
        public long TtkScore { get; set; }
        public string Title { get; set; } = null!;
    }
}
