using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class AlbumVoiceList
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public string SheetId { get; set; } = null!;
        public string VoiceId { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
