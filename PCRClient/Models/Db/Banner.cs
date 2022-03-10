using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class Banner
    {
        public long BannerId { get; set; }
        public long Type { get; set; }
        public long SystemId { get; set; }
        public long GachaId { get; set; }
        public long Priority { get; set; }
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public long SubBannerId1 { get; set; }
        public long IsShowRoom { get; set; }
        public string Url { get; set; } = null!;
        public long ShowType { get; set; }
        public long ThumbnailId { get; set; }
        public long PosterId { get; set; }
    }
}
