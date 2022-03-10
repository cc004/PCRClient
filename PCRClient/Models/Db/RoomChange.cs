using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomChange
    {
        public long RoomItemId { get; set; }
        public long ChangeId { get; set; }
        public string ChangeStart { get; set; } = null!;
        public string ChangeEnd { get; set; } = null!;
    }
}
