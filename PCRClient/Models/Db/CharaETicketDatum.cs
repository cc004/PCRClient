using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CharaETicketDatum
    {
        public long TicketId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long JewelStoreId { get; set; }
    }
}
