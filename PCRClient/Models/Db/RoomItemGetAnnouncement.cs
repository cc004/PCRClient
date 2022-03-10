using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomItemGetAnnouncement
    {
        public long Id { get; set; }
        public long RoomItemId { get; set; }
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public string GetDate { get; set; } = null!;
    }
}
