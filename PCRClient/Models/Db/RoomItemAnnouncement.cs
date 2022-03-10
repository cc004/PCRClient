using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomItemAnnouncement
    {
        public long Id { get; set; }
        public string AnnouncementStart { get; set; } = null!;
        public string AnnouncementEnd { get; set; } = null!;
        public string AnnouncementText { get; set; } = null!;
    }
}
